/* transpiled with BefunCompile v1.3.0 (c) 2017 */
class Program{
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1;
long x0=1000000;
long x1=0;
long x2=1;
long x3=0;
long x4=35;
long x5=35;
long x6=35;
private int _0(){
    sa(1);
    sa(2);
    sa(4+(x2*x2));
    sa(((4+(x2*x2))%64)>57?1:0);
    return 1;
}
private int _1(){
    if(sp()!=0)return 31;else return 2;
}
private int _2(){
    sa(sr()%16);

    if(sr()>9)return 3;else return 15;
}
private int _3(){
    sp();
    return 4;
}
private int _4(){
    sp();
    sa(0);
    return 5;
}
private int _5(){
    if(sp()!=0)return 11;else return 6;
}
private int _6(){
    sa(sr());

    if(sp()!=0)return 10;else return 7;
}
private int _7(){
    t0=x3+x1;
    x1=x3+x1;
    t0=t0>x0?1:0;
    sp();

    if((t0)!=0)return 8;else return 9;
}
private int _8(){
    System.out.print(String.valueOf((long)(sp()))+" ");
    return 32;
}
private int _9(){
    sa(sp()+1L);

    sa(sr());
    x2=sr();
    x3=0;
    sa(sp()*2L);

    sa(sp()+1L);

    sa(sp()-1L);

    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(sp()+(x2*x2));

    sa((sr()%64)>57?1:0);
    return 1;
}
private int _10(){
    sa(sp()-1L);

    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(sp()+(x2*x2));

    sa((sr()%64)>57?1:0);
    return 1;
}
private int _11(){
    if(sr()>x2)return 14;else return 12;
}
private int _12(){
    sa((sr()/2)+x3);
    return 13;
}
private int _13(){
    x3=sp();
    t0=1;
    return 6;
}
private int _14(){
    t0=(sr()+1)/2;
    t1=x2;
    sa((t1-t0)+1+x3);
    return 13;
}
private int _15(){
    if(sr()!=2)return 16;else return 3;
}
private int _16(){
    if(sr()!=3)return 17;else return 3;
}
private int _17(){
    if(sr()!=5)return 18;else return 3;
}
private int _18(){
    if(sr()!=6)return 19;else return 3;
}
private int _19(){
    if(sr()!=7)return 20;else return 3;
}
private int _20(){
    sa(sp()-8L);


    if(sp()!=0)return 21;else return 31;
}
private int _21(){
    sa(sr()%10);

    if(sr()!=7)return 22;else return 3;
}
private int _22(){
    if(sr()!=3)return 23;else return 3;
}
private int _23(){
    sa(sp()-2L);


    if(sp()!=0)return 25;else return 24;
}
private int _24(){
    sa(0);
    return 3;
}
private int _25(){
    if((sr()%3)!=2)return 26;else return 4;
}
private int _26(){
    x4=0;
    x5=sr();
    return 27;
}
private int _27(){
    x6=sr();
    t0=x5;
    sa(sr());
    sa(t0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    {long v0=sp();sa(td(sp(),v0));}

    t1=sp();
    sa(sp()+t1);

    sa(sp()/2L);


    if((sr()-x6)!=0)return 29;else return 28;
}
private int _28(){
    sp();
    sa(((x6*x6)-x5!=0)?0:1);
    return 5;
}
private int _29(){
    if((sr()-x4)!=0)return 30;else return 28;
}
private int _30(){
    x4=x6;
    return 27;
}
private int _31(){
    t0=2;
    return 4;
}

public void main(){
    int c=0;
    while(c<32){
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
    case 22:c=_22();break;
    case 23:c=_23();break;
    case 24:c=_24();break;
    case 25:c=_25();break;
    case 26:c=_26();break;
    case 27:c=_27();break;
    case 28:c=_28();break;
    case 29:c=_29();break;
    case 30:c=_30();break;
    case 31:c=_31();break;
}
}
}
public static void main(String[]a){new Program().main();}
}
