
package data;


public class VehicleCatalog {
    int next=0;
    int max = 3;
    Car[] vehicleList = new Car[max];
    
    public void addCar(){
        if(next == max){
            System.out.println("Het memory");
            return;
        }
        Car c = new Car();
        c.accept();
        vehicleList[next] = c;
        next++;
    }
    public void displayAll(){
        if(next==0){
            System.out.println(">>HT chua co du lieu");
            return;
        }else{
            System.out.println(">>DS vehicle");
            for (int i = 0; i < next; i++) {
                vehicleList[i].printInfo();
            }
        }
    }
    
    //còn thieu mot ham
    public void searchByBrand(String sBrand){
        for (int i = 0; i < next; i++) {
            if(sBrand.equalsIgnoreCase(vehicleList[i].brand)){
                System.out.println(vehicleList[i]);
            }
        }
    }
    
    public void displayAllGPSCar(){
        for (int i = 0; i < next; i++) {
            if(vehicleList[i].getGPSStatus()){
                System.out.println(vehicleList[i]);
            }
        }
    }
    
    public void displayHighRankl(){
        for (int i = 0; i < next; i++) {
            if(vehicleList[i].price>50000){
                vehicleList[i].printInfo();
            }
        }
    }
    
    
}
