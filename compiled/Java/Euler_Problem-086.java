/* transpiled with BefunCompile v1.2.0 (c) 2017 */
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
    sa((tm(4+(x2*x2),64))>57?1:0);
    return 1;
}
private int _1(){
    if(sp()!=0)return 3;else return 2;
}
private int _2(){
    t0=tm(sr(),16);

    if(t0>9)return 3;else return 9;
}
private int _3(){
    sp();
    return 4;
}
private int _4(){
    sa(sr());
    sa((sp()!=0)?0:1);

    if(sp()!=0)return 5;else return 8;
}
private int _5(){
    sp();
    t0=x3+x1;
    x1=x3+x1;
    t0=t0>x0?1:0;

    if((t0)!=0)return 6;else return 7;
}
private int _6(){
    System.out.print(String.valueOf((long)(sp()))+" ");
    return 28;
}
private int _7(){
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

    sa((tm(sr(),64))>57?1:0);
    return 1;
}
private int _8(){
    sa(sp()-1L);

    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(sp()+(x2*x2));

    sa((tm(sr(),64))>57?1:0);
    return 1;
}
private int _9(){
    if(t0!=2)return 10;else return 3;
}
private int _10(){
    if(t0!=3)return 11;else return 3;
}
private int _11(){
    if(t0!=5)return 12;else return 3;
}
private int _12(){
    if(t0!=6)return 13;else return 3;
}
private int _13(){
    if(t0!=7)return 14;else return 3;
}
private int _14(){
    t0-=8;
    t0=(t0!=0)?0:1;

    if((t0)!=0)return 3;else return 15;
}
private int _15(){
    t0=tm(sr(),10);

    if(t0-7==0)return 3;else return 16;
}
private int _16(){
    if(t0-3==0)return 3;else return 17;
}
private int _17(){
    t0-=2;
    t0=(t0!=0)?0:1;

    if((t0)!=0)return 3;else return 18;
}
private int _18(){
    if((tm(sr(),3))!=2)return 19;else return 3;
}
private int _19(){
    x4=0;
    x5=sr();
    return 20;
}
private int _20(){
    x6=sr();
    sa(sr());
    t0=x5;
    sa(t0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    {long v0=sp();sa(td(sp(),v0));}

    t1=sp();
    sa(sp()+t1);

    sa(td(sp(),2));


    if(sr()!=x6)return 26;else return 21;
}
private int _21(){
    sp();

    if((x6*x6)-x5==0)return 22;else return 4;
}
private int _22(){
    if(sr()>x2)return 25;else return 23;
}
private int _23(){
    sa((td(sr(),2))+x3);
    return 24;
}
private int _24(){
    x3=sp();
    return 4;
}
private int _25(){
    t0=td(sr()+1,2);
    t1=x2;
    sa(t1-t0);
    sa(sp()+1L);

    sa(sp()+x3);
    return 24;
}
private int _26(){
    if(sr()!=x4)return 27;else return 21;
}
private int _27(){
    x4=x6;
    return 20;
}

public void main(){
    int c=0;
    while(c<28){
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
}
}
}
public static void main(String[]a){new Program().main();}
}
