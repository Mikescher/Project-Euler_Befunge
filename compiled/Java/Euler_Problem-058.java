/* transpiled with BefunCompile v1.2.0 (c) 2017 */
class Program{
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1,t2;
long x0=2;
long x1=1;
long x2=0;
long x3=35;
long x4=35;
long x5=35;
long x6=35;
long x7=35;
long x8=35;
long x9=35;
private int _0(){
    sa(3);
    sa(3);
    return 1;
}
private int _1(){
    if(sr()-2==0)return 2;else return 11;
}
private int _2(){
    sp();
    return 3;
}
private int _3(){
    x2++;
    return 4;
}
private int _4(){
    t0=x1+1;
    x1++;
    t0=t0<(x2*10)?1:0;

    if((t0)!=0)return 5;else return 10;
}
private int _5(){
    sa(sp()+x0);


    if(tm(x1,4)!=0)return 6;else return 9;
}
private int _6(){
    sa(sr());
    sa(sr()<2?1:0);
    return 7;
}
private int _7(){
    if(sp()!=0)return 8;else return 1;
}
private int _8(){
    sp();
    return 4;
}
private int _9(){
    x0+=2;
    sa(sr());
    sa(sr()<2?1:0);
    return 7;
}
private int _10(){
    System.out.print(String.valueOf(((td(x1-2,4))*2)+3)+" ");
    sp();
    return 35;
}
private int _11(){
    if(tm(sr(),2)==0)return 8;else return 12;
}
private int _12(){
    if(sr()<9)return 2;else return 13;
}
private int _13(){
    if(tm(sr(),3)==0)return 8;else return 14;
}
private int _14(){
    if(tm(sr(),5)==0)return 8;else return 15;
}
private int _15(){
    x4=1;
    return 16;
}
private int _16(){
    sa(sr());
    t0=x4+1;
    x4++;
    x3=sr();
    sa(sp()-1L);

    t1=0;
    return 17;
}
private int _17(){
    if(tm(sr(),2)==0)return 18;else return 19;
}
private int _18(){
    sa(td(sp(),2));

    t1++;
    return 17;
}
private int _19(){
    x5=t1;
    x7=x3;
    x6=sp();
    x8=t0;
    x9=1;
    sa(0);
    sa(x6);
    sa((x6!=0)?0:1);
    return 20;
}
private int _20(){
    if(sp()!=0)return 21;else return 34;
}
private int _21(){
    sp();
    sa(1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    return 22;
}
private int _22(){
    sa(sr());

    if(sp()!=0)return 23;else return 26;
}
private int _23(){
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa(sp()*sp());

    sa(tm(sp(),x7));

    t0=td(x9,2);
    x9/=2;
    t1=x6;
    t2=td(t1,t0);
    t2%=2;
    t2=(t2!=0)?0:1;

    if((t2)!=0)return 24;else return 25;
}
private int _24(){
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()-1L);
    return 22;
}
private int _25(){
    sa(sp()*x8);

    sa(tm(sp(),x7));
    return 24;
}
private int _26(){
    sp();
    sa(x5);
    sa(x5);
    return 27;
}
private int _27(){
    if(sp()!=0)return 28;else return 32;
}
private int _28(){
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    t0=sp();
    t0%=x3;
    t0--;
    t0=(t0!=0)?0:1;
    t1=(sr()-1!=0)?1:0;
    sa(sp()-x3);

    sa(sp()+1L);

    sa((sp()!=0)?0:1);
    sa((sp()!=0)?0:1);
    sa(t1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+sp());

    t2=sp();
    t1=t0+t2;
    t1-=3;

    if((t1)!=0)return 31;else return 29;
}
private int _29(){
    sp();
    sp();
    sa(x4);
    return 30;
}
private int _30(){
    sp();
    sp();
    return 4;
}
private int _31(){
    sa(sr());
    sa(sp()*sp());

    sa(tm(sp(),x3));

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()-1L);

    sa(sr());
    return 27;
}
private int _32(){
    sp();
    sa(sp()-1L);

    sa((sp()!=0)?0:1);
    sa((sp()!=0)?0:1);
    sa(x4);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa((sp()!=0)?0:1);

    if(sp()!=0)return 33;else return 30;
}
private int _33(){
    sa(sp()-3L);


    if(sp()!=0)return 16;else return 2;
}
private int _34(){
    x9*=2;
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+1L);

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),2));

    sa(sr());
    sa((sp()!=0)?0:1);
    return 20;
}

public void main(){
    int c=0;
    while(c<35){
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
    case 32:c=_32();break;
    case 33:c=_33();break;
    case 34:c=_34();break;
}
}
}
public static void main(String[]a){new Program().main();}
}
