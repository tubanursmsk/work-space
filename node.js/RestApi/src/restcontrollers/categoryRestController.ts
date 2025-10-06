import express from 'express'
import { AuthRequest, checkRole, verifyToken } from '../configs/auth';
import { eRoles } from '../utils/eRoles';
import Category, { ICategory } from '../models/category'; // Model'i import et
import { JwtPayload } from 'jsonwebtoken';

const categoryRestController = express.Router()

/**
 * @swagger
 * tags:
 *   name: Categories
 *   description: Category management
 */

/**
 * @swagger
 * components:
 *   schemas:
 *     Category:
 *       type: object
 *       required:
 *         - name
 *       properties:
 *         _id:
 *           type: string
 *           example: "60f7c2b8e1d3c2a5b8e1d3c2"
 *         name:
 *           type: string
 *           minLength: 2
 *           maxLength: 50
 *           example: "Electronics"
 *         description:
 *           type: string
 *           example: "All electronic items"
 *         createdAt:
 *           type: string
 *           format: date-time
 *           example: "2024-06-01T12:00:00.000Z"
 *         updatedAt:
 *           type: string
 *           format: date-time
 *           example: "2024-06-01T12:00:00.000Z"
 */

/**
 * @swagger
 * /categories/add:
 *   post:
 *     summary: Add a new category
 *     tags: [Categories]
 *     security:
 *       - bearerAuth: []
 *     requestBody:
 *       required: true
 *       content:
 *         application/json:
 *           schema:
 *             $ref: '#/components/schemas/Category'
 *           example:
 *             name: "Books"
 *             description: "All kinds of books"
 *     responses:
 *       201:
 *         description: Category added successfully
 *         content:
 *           application/json:
 *             schema:
 *               type: object
 *               properties:
 *                 message:
 *                   type: string
 *                   example: Category added successfully
 *                 category:
 *                   $ref: '#/components/schemas/Category'
 *       400:
 *         description: Invalid category name
 *       401:
 *         description: Unauthorized
 *       403:
 *         description: Forbidden (Admin only)
 *       500:
 *         description: Internal server error
 */

/**
 * @swagger
 * /categories/list:
 *   get:
 *     summary: List categories (paginated, 10 per page)
 *     tags: [Categories]
 *     security:
 *       - bearerAuth: []
 *     parameters:
 *       - in: query
 *         name: page
 *         schema:
 *           type: integer
 *           default: 1
 *         description: Page number
 *     responses:
 *       200:
 *         description: List of categories
 *         content:
 *           application/json:
 *             schema:
 *               type: object
 *               properties:
 *                 categories:
 *                   type: array
 *                   items:
 *                     $ref: '#/components/schemas/Category'
 *                 page:
 *                   type: integer
 *                   example: 1
 *       401:
 *         description: Unauthorized
 *       403:
 *         description: Forbidden (Admin only)
 *       500:
 *         description: Internal server error
 */

// Kategori ekleme
categoryRestController.post('/add', verifyToken, checkRole(eRoles.Admin), async (req: AuthRequest, res) => {
  try {
    const categorydata = req.body as ICategory;
    const user = req.user as JwtPayload;
    
    if (!categorydata.name || categorydata.name.length < 2 || categorydata.name.length > 50) {
      return res.status(400).json({ message: 'Invalid category name' });
    }
    const newCategory = new Category(categorydata);
    await newCategory.save();

    return res.status(201).json({ 
      message: 'Category added successfully', 
      category: newCategory 
    });
  } catch (error) {
    return res.status(500).json({ message: 'Internal server error', error });
  }
});

// Kategori listeleme (10'ar 10'ar)
categoryRestController.get('/list', verifyToken, checkRole(eRoles.Admin), async (req, res) => {
  try {
    const page = parseInt(req.query.page as string) || 1;
    const limit = 10;
    const skip = (page - 1) * limit;
    const categories = await Category.find()
      .skip(skip)
      .limit(limit)
      .sort({ createdAt: -1 });

    return res.status(200).json({ 
      categories,
      page
    });
  } catch (error) {
    return res.status(500).json({ message: 'Internal server error', error });
  }
});

// Router'ı export et
export default categoryRestController;
