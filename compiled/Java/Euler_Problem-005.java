/* transpiled with BefunCompile v1.3.0 (c) 2017 */
class Program{
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
long t0;
long x0=20;
long x1=1;
long x2=1;
long x3=48;
long x4=112;
long x5=48;
private int _0(){
    return 1;
}
private int _1(){
    x1*=x2;
    t0=x0>(x2+1)?1:0;
    x2++;

    if((t0)!=0)return 3;else return 2;
}
private int _2(){
    System.out.print(String.valueOf(x1)+" ");
    return 10;
}
private int _3(){
    x3=1;
    return 4;
}
private int _4(){
    t0=x3;
    x3++;
    t0=t0>x0?1:0;

    if((t0)!=0)return 1;else return 5;
}
private int _5(){
    if((tm(x1,x3))!=0)return 4;else return 6;
}
private int _6(){
    x5=td(x1,x3);
    x4=1;
    return 7;
}
private int _7(){
    t0=x2>(x4+1)?1:0;
    x4++;

    if((t0)!=0)return 9;else return 8;
}
private int _8(){
    x1/=x3;
    return 5;
}
private int _9(){
    if((tm(x5,x4))!=0)return 4;else return 7;
}

public void main(){
    int c=0;
    while(c<10){
    switch(c){
    case 0:c=_0();break;
    case 1:c=_1();break;
    case 2:c=_2();break;
    case 3:c=_3();break;
    case 4:c=_4();break;
    case 5:c=_5();break;
    case 6:c=_6();break;
    case 7:c=_7();break;
    case 8:c=_8();break;
    case 9:c=_9();break;
}
}
}
public static void main(String[]a){new Program().main();}
}
