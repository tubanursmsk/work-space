const baseURL = "https://dummyjson.com/"


// products
export const productURL = {
    products: `${baseURL}products`,
    productById: (id: number) => `${baseURL}products/${id}`
}
