/* transpiled with BefunCompile v1.2.0 (c) 2017 */
class Program{
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1,t2,t3;
long x0=4818;
private int _0(){
    sa(1488);
    sa(1800);
    sa(1800);
    return 1;
}
private int _1(){
    if((((tm(x0,10))+2)*((tm(td(x0,10),10))+2)*((tm(td(td(x0,10),10),10))+2)*((td(td(td(x0,10),10),10))+2))!=(((tm(x0+3330,10))+2)*((tm(td(x0+3330,10),10))+2)*((tm(td(td(x0+3330,10),10),10))+2)*((td(td(td(x0+3330,10),10),10))+2)))return 15;else return 2;
}
private int _2(){
    {long v0=sp();sa(sp()-v0);}

    t0=sp();
    t0=(t0!=0)?0:1;

    if((t0)!=0)return 3;else return 15;
}
private int _3(){
    sa(sr());
    return 4;
}
private int _4(){
    if(sr()>9999)return 14;else return 5;
}
private int _5(){
    sa(sr());

    if(tm(sr(),2)==0)return 6;else return 7;
}
private int _6(){
    sp();
    sp();
    sa(sp()+1L);

    sa(sr());
    sa(sr());
    t0=(tm(sr(),10))+2;
    sa(td(sp(),10));

    t1=(tm(sr(),10))+2;
    sa(td(sp(),10));

    t2=(tm(sr(),10))+2;
    sa(td(sp(),10));

    sa(sp()+2L);

    sa(t2);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()*sp());

    t3=sp();
    t2=t1*t3;
    sa(t0*t2);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+3330L);

    x0=sp();
    sa(sr());
    return 1;
}
private int _7(){
    if(tm(sr(),3)==0)return 6;else return 8;
}
private int _8(){
    x0=sp();
    sa(7);
    sa((tm(x0,7)!=0)?0:1);
    return 9;
}
private int _9(){
    if(sp()!=0)return 6;else return 10;
}
private int _10(){
    if(sr()>(td(x0,2)))return 13;else return 11;
}
private int _11(){
    t0=sr()-2;
    t1=x0;
    t2=tm(t1,t0);

    if((t2)!=0)return 12;else return 6;
}
private int _12(){
    sa(sp()+6L);

    sa(sr());
    t0=x0;
    sa(t0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    {long v0=sp();sa(tm(sp(),v0));}

    sa((sp()!=0)?0:1);
    return 9;
}
private int _13(){
    sp();
    sa(sp()+3330L);
    return 4;
}
private int _14(){
    sp();
    sa(sr());
    System.out.print(String.valueOf((long)(sp()))+" ");
    System.out.print(' ');
    sa(sp()+3330L);

    sa(sr());
    System.out.print(String.valueOf((long)(sp()))+" ");
    System.out.print(' ');
    sa(sp()+3330L);

    System.out.print(String.valueOf((long)(sp()))+" ");
    return 16;
}
private int _15(){
    sp();
    sp();
    sa(sp()+1L);

    sa(sr());
    sa(sr());
    t0=(tm(sr(),10))+2;
    sa(td(sp(),10));

    t1=(tm(sr(),10))+2;
    sa(td(sp(),10));

    t2=(tm(sr(),10))+2;
    sa(td(sp(),10));

    sa(sp()+2L);

    sa(t2);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()*sp());

    t3=sp();
    t2=t1*t3;
    sa(t0*t2);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+3330L);

    x0=sp();
    sa(sr());
    return 1;
}

public void main(){
    int c=0;
    while(c<16){
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
}
}
}
public static void main(String[]a){new Program().main();}
}
