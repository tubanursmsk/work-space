"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.jsonResult = void 0;
const jsonResult = (code = 200, status, message, data) => {
    return {
        code,
        status,
        message,
        data
    };
};
exports.jsonResult = jsonResult;
//# sourceMappingURL=result.js.map