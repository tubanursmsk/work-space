import mongoose, { Schema } from "mongoose";

export interface INews {
  title: string;
  content: string;
  category: mongoose.Types.ObjectId;
  author: mongoose.Types.ObjectId;
  createdAt?: Date;
  updatedAt?: Date;
}

const NewsSchema: Schema<INews> = new Schema(
  {
    title: { type: String, required: true, minlength: 2, trim: true },
    content: { type: String, required: true, minlength: 2 },
    category: { type: Schema.Types.ObjectId, ref: "Category", required: true },
    author: { type: Schema.Types.ObjectId, ref: "User", required: true } // User referansı
  },
  {
    timestamps: true // createdAt ve updatedAt otomatik yönetilir. Serviste bu değerlerle uğraşmamıza gerek yok.
  }
);

const News = mongoose.model<INews>("News", NewsSchema);
export default News;