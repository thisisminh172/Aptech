package goods;

public class LaptopCatalog {

    final int max = 10;
    int cnt = 0;
    Laptop[] cList = new Laptop[max];
    
    public void addLaptop(){
        if(cnt == max){
            System.out.println("het cho de them laptop");
            return;
        }
        Laptop l = new Laptop();
        l.accept();
        cList[cnt]=l;
        cnt++;
    }
    
    public void displayAll(){
        if(cnt == 0){
            System.out.println("khong co laptop trong danh sach");
            return;
        }
        System.out.println("\nDanh sach cac laptop:");
        for (int i = 0; i < cnt; i++) {
            System.out.println("\t"+cList[i]);
        }
    }
    
    public void search(String laptopName){
        if(cnt == 0){
            System.out.println("khong co laptop trong danh sach");
            return;
        }
        int demName = 0;
        for (int i = 0; i < cnt; i++) {
            if(cList[i].name.contains(laptopName)){
                cList[i].printInfo();
                demName++;
            }
        }
        
        if(demName==0){
            System.out.println(">>>Khong tim thay ten<<<");
        }
    }
    
    //tim laptop theo ma so va xoa laptop do ra khoi list
    public void remove(String laptopID){
        if(cnt == 0){
            System.out.println("khong co laptop trong danh sach");
            return;
        }
        
        int demID = 0;
        for (int i = 0; i < cnt; i++) {
            if(cList[i].id.equals(laptopID)){
                //viet vong lap con di chuyen cac  laptop o cac dong duoi len 1 vi tri
                for(int k =i;k<cnt;k++){
                    cList[k]= cList[k+1];
                }
                
                demID++;
                System.out.println(">>Da xoa laptop co id: "+cList[i].id);
                cnt--;
                break;
            }
        }
        
        if(demID==0){
            System.out.println(">>>Khong tim thay ten<<<");
        }
        
        
    }
}
