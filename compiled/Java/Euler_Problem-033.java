/* transpiled with BefunCompile v1.1.0 (c) 2015 */
class Program{
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0;
long x0=1;
long x1=1;
long x2=99;
long x3=99;
long x4=32;
private int _0(){
    return 1;
}
private int _1(){
    if(x3<=x2)return 2;else return 8;
}
private int _2(){
    t0=x2-1;
    x2--;
    t0-=9;
    t0=(t0!=0)?0:1;

    if((t0)!=0)return 3;else return 7;
}
private int _3(){
    sp();
    sa(x0);
    sa(x1);

    if((x1)!=0)return 5;else return 4;
}
private int _4(){
    sp();
    sa(x1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    {long v0=sp();sa(td(sp(),v0));}

    System.out.print(String.valueOf((long)(sp())));
    return 22;
}
private int _5(){
    x4=sr();
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(tm(sp(),x4));

    sa(sr());
    return 6;
}
private int _6(){
    if(sp()!=0)return 5;else return 4;
}
private int _7(){
    x3=99;
    return 1;
}
private int _8(){
    if(td(x2,10)!=0)return 20;else return 9;
}
private int _9(){
    if(td(x2,10)!=0)return 18;else return 10;
}
private int _10(){
    if(tm(x2,10)!=0)return 16;else return 11;
}
private int _11(){
    if(tm(x2,10)!=0)return 13;else return 12;
}
private int _12(){
    t0=x3-1;
    x3--;
    t0-=9;
    t0=(t0!=0)?0:1;

    if((t0)!=0)return 2;else return 1;
}
private int _13(){
    if((tm(x2,10))!=(tm(x3,10)))return 12;else return 14;
}
private int _14(){
    if((x2*(tm(x3,10)))!=(x3*(tm(x2,10))))return 12;else return 15;
}
private int _15(){
    x0*=x2;
    x1*=x3;
    return 12;
}
private int _16(){
    if((tm(x2,10))!=(td(x3,10)))return 11;else return 17;
}
private int _17(){
    if((x2*(tm(x3,10)))!=(x3*(td(x2,10))))return 11;else return 15;
}
private int _18(){
    if((td(x2,10))!=(tm(x3,10)))return 10;else return 19;
}
private int _19(){
    if((x2*(td(x3,10)))!=(x3*(tm(x2,10))))return 10;else return 15;
}
private int _20(){
    if((td(x2,10))!=(td(x3,10)))return 9;else return 21;
}
private int _21(){
    if((x2*(td(x3,10)))!=(x3*(td(x2,10))))return 9;else return 15;
}

public void main(){
    int c=0;
    while(c<22){
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
    case 10:c=_10();break;
    case 11:c=_11();break;
    case 12:c=_12();break;
    case 13:c=_13();break;
    case 14:c=_14();break;
    case 15:c=_15();break;
    case 16:c=_16();break;
    case 17:c=_17();break;
    case 18:c=_18();break;
    case 19:c=_19();break;
    case 20:c=_20();break;
    case 21:c=_21();break;
}
}
}
public static void main(String[]a){new Program().main();}
}
