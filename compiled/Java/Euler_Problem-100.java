/* transpiled with BefunCompile v1.3.0 (c) 2017 */
class Program{
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
long t0;
long x0=1;
long x1=1;
long x2=0;
long x3=0;
private int _0(){
    return 1;
}
private int _1(){
    t0=(x2*3)+(x0*2);
    x0=(x0*3)+(x2*4);
    x2=t0;
    t0=(x3*3)-(x1*2);
    x1=(x1*3)-(x3*4);
    x3=t0;
    return 2;
}
private int _2(){
    if((((2+(x2*2))-x0-(2*x3)-x1)/4)>1000000000000L)return 3;else return 1;
}
private int _3(){
    System.out.print(String.valueOf(((4+(x1*2)+(x3*2)+(x0*2))-(x2*2))/8)+" ");
    return 4;
}

public void main(){
    int c=0;
    while(c<4){
    switch(c){
    case 0:c=_0();break;
    case 1:c=_1();break;
    case 2:c=_2();break;
    case 3:c=_3();break;
}
}
}
public static void main(String[]a){new Program().main();}
}
