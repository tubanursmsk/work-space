"use strict";
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", { value: true });
const express_1 = __importDefault(require("express"));
const path_1 = __importDefault(require("path"));
const body_parser_1 = __importDefault(require("body-parser"));
const dotenv_1 = __importDefault(require("dotenv"));
const db_1 = require("./configs/db");
// .env Config - .env file loading
dotenv_1.default.config({ path: path_1.default.resolve(__dirname, '../.env') });
const app = (0, express_1.default)();
const PORT = process.env.PORT || 4000;
// DB Config
(0, db_1.connectDB)();
// body-parser Config
app.use(body_parser_1.default.urlencoded({ extended: false }));
app.use(body_parser_1.default.json());
// import Rest Controllers
const userRestController_1 = __importDefault(require("./restcontrollers/userRestController"));
// Routers Config
app.use('/api/v1/users', userRestController_1.default);
app.listen(PORT, () => {
    console.log(`Server running: http://localhost:${PORT}`);
});
//# sourceMappingURL=app.js.map