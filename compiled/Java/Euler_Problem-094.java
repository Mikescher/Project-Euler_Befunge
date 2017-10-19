/* transpiled with BefunCompile v1.3.0 (c) 2017 */
class Program{
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
long t0;
long x0=0;
long x1=1000000000;
long x2=2;
long x3=1;
private int _0(){
    return 1;
}
private int _1(){
    if(x1>(x2*2))return 3;else return 2;
}
private int _2(){
    System.out.print(String.valueOf(x0)+" ");
    return 4;
}
private int _3(){
    x0=((x2>2?1:0)*((((2*x2)%3)-1!=0)?0:1)*((((x2-2)*x3)%3!=0)?0L:1L)*((x2*2)-2))+x0;
    x0=(((((x2*2)%3)-2!=0)?0:1)*((((x2+2)*x3)%3!=0)?0L:1L)*(2+(2*x2)))+x0;
    t0=x2+(x3*2);
    x2=(x2*2)+(x3*3);
    x3=t0;
    return 1;
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
