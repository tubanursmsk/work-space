import Category, { ICategory } from "../models/category";
import { IResult, jsonResult } from "../models/result";
import mongoose from "mongoose";



export const addCategory = async (categoryData: ICategory, userId: string): Promise<IResult> => {
    try {
        // Kategori adı zaten var mı kontrol et
        const existingCategory = await Category.findOne({ 
            name: { $regex: new RegExp(`^${categoryData.name}$`, 'i') } // Case-insensitive
        });

        if (existingCategory) {
            return jsonResult(400, false, 'Category already exists', null);
        }

        // Yeni kategori oluştur
        const newCategory = new Category({
            name: categoryData.name,
            description: categoryData.description,
            isActive: categoryData.isactive ?? true,
            createdBy: userId
        });

        await newCategory.save();
        
        return jsonResult(201, true, 'Category created successfully', {
            id: newCategory._id,
            name: newCategory.name,
            description: newCategory.description,
            isActive: newCategory.isactive,
            createdAt: newCategory.createdAt
        });

    } catch (error) {
        console.error('Add Category Error:', error);
        return jsonResult(500, false, 'Internal server error', error.message);
    }

};


/*
// Haber silme (Admin)
export const removeCategory = async (category: mongoose.Types.ObjectId) => {
  try {
    if (!mongoose.Types.ObjectId.isValid(category)) {
      return jsonResult(400, false, "Invalid id", null);
    }

    const deleted = await Category.findByIdAndDelete(category);
    if (!deleted) {
      return jsonResult(404, false, "News not found", null);
    }

    return jsonResult(200, true, "News deleted successfully", {
      id: deleted._id,
      name: deleted.name,
      description: deleted.description
    });
  } catch (error: any) {
    console.error("Remove News Error:", error);
    return jsonResult(500, false, "Internal server error", error.message);
  }
};
*/



