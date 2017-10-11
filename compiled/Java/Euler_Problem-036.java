/* transpiled with BefunCompile v1.2.0 (c) 2017 */
class Program{
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1;
long x0=9990;
private int _0(){
    sa(0);
    sa(0);
    sa(999);
    sa(9+x0);
    sa(99);
    return 1;
}
private int _1(){
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()*10L);

    x0=sp();
    sa((tm(sr(),10))+x0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),10));

    sa(sr());
    return 2;
}
private int _2(){
    if(sp()!=0)return 1;else return 3;
}
private int _3(){
    x0=0;
    sp();
    sa(sr());
    sa(sr());
    return 4;
}
private int _4(){
    t0=(tm(sr(),2))+x0;
    sa(td(sp(),2));

    sa(sr());

    if(sp()!=0)return 25;else return 5;
}
private int _5(){
    sp();
    sa(sp()-t0);

    t1=sp();
    t1=(t1!=0)?0:1;

    if((t1)!=0)return 24;else return 6;
}
private int _6(){
    sp();
    return 7;
}
private int _7(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 8;else return 9;
}
private int _8(){
    sa(sr());
    t0=sr()*10;
    x0=t0;
    sa((tm(sr(),10))+x0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),10));

    sa(sr());
    return 2;
}
private int _9(){
    x0=990;
    sa(999);
    sa(9+x0);
    sa(99);
    return 10;
}
private int _10(){
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()*10L);

    x0=sp();
    sa((tm(sr(),10))+x0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),10));

    sa(sr());
    return 11;
}
private int _11(){
    if(sp()!=0)return 10;else return 12;
}
private int _12(){
    x0=0;
    sp();
    sa(sr());
    sa(sr());
    return 13;
}
private int _13(){
    t0=(tm(sr(),2))+x0;
    sa(td(sp(),2));

    sa(sr());

    if(sp()!=0)return 23;else return 14;
}
private int _14(){
    sp();
    sa(sp()-t0);

    t1=sp();
    t1=(t1!=0)?0:1;

    if((t1)!=0)return 22;else return 15;
}
private int _15(){
    sp();
    return 16;
}
private int _16(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 17;else return 18;
}
private int _17(){
    sa(sr());
    t0=(td(sr(),10))*10;
    x0=t0;
    sa((tm(sr(),10))+x0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),10));

    sa(sr());
    return 11;
}
private int _18(){
    System.out.print(" =");
    return 19;
}
private int _19(){
    sa(sp()+sp());

    t0=sp();
    sa(sr());

    if(sp()!=0)return 20;else return 21;
}
private int _20(){
    sa(sp()+t0);
    return 19;
}
private int _21(){
    sa(t0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+sp());

    t1=sp();
    System.out.print(String.valueOf(t1)+" ");
    return 26;
}
private int _22(){
    sa(sr());
    System.out.print(String.valueOf((long)(sp()))+" ");
    System.out.print('\n');
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    return 16;
}
private int _23(){
    t0*=2;
    x0=t0;
    return 13;
}
private int _24(){
    sa(sr());
    System.out.print(String.valueOf((long)(sp()))+" ");
    System.out.print('\n');
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    return 7;
}
private int _25(){
    t0*=2;
    x0=t0;
    return 4;
}

public void main(){
    int c=0;
    while(c<26){
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
}
}
}
public static void main(String[]a){new Program().main();}
}
