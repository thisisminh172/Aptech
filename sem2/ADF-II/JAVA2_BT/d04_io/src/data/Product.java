/*
 * Mo ta 1 san pham, bao gom:
ma so , ten , don gia
 */
package data;


public class Product implements java.io.Serializable {
    public String id, name;
    public int price;

    public Product() {
    }

    public Product(String id, String name, int price) {
        this.id = id;
        this.name = name;
        this.price = price;
    }

    @Override
    public String toString() {
        return String.format("%s , %s, %d",id,name,price);
    }
    
}
