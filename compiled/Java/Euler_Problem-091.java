/* transpiled with BefunCompile v1.3.0 (c) 2017 */
class Program{
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
long t0,t1;
long x0=50;
long x1=0;
long x2=50;
long x3=88;
long x4=88;
private int _0(){
    return 1;
}
private int _1(){
    x3=x0;
    x4=x3+1;
    return 2;
}
private int _2(){
    if((((x3*(x4-x3))>(x2*x2)?1:0)+(x4>x0?1L:0L))!=0)return 3;else return 7;
}
private int _3(){
    t0=x3-1;
    t1=6;
    x3--;

    if((t0)!=0)return 6;else return 4;
}
private int _4(){
    t0=x2-1;
    t1=x2-1;
    x2=t1;

    if((t0)!=0)return 1;else return 5;
}
private int _5(){
    System.out.print(String.valueOf(x1+(3*x0*x0))+" ");
    return 8;
}
private int _6(){
    x4=x3+1;
    return 2;
}
private int _7(){
    x1+=((tm((x3-x4)*x3,x2)!=0)?0:1)*2L;
    x4++;
    return 2;
}

public void main(){
    int c=0;
    while(c<8){
    switch(c){
    case 0:c=_0();break;
    case 1:c=_1();break;
    case 2:c=_2();break;
    case 3:c=_3();break;
    case 4:c=_4();break;
    case 5:c=_5();break;
    case 6:c=_6();break;
    case 7:c=_7();break;
}
}
}
public static void main(String[]a){new Program().main();}
}
