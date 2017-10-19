/* transpiled with BefunCompile v1.3.0 (c) 2017 */
class Program{
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1;
long x0=32;
long x1=32;
private int _0(){
    sa(0);
    sa(10000);
    sa(10000);
    sa(0);
    sa(10000);
    sa(0);
    return 1;
}
private int _1(){
    if(sp()!=0)return 3;else return 2;
}
private int _2(){
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()*10L);

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    t0=sr()%10;
    x1=t0;
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+x1);

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()/10L);

    sa(sr());
    sa((sp()!=0)?0:1);
    return 1;
}
private int _3(){
    sp();
    sa(sp()+sp());

    sa(24);
    sa(0);
    return 4;
}
private int _4(){
    if(sp()!=0)return 5;else return 9;
}
private int _5(){
    sp();
    sp();
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+1L);

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    return 6;
}
private int _6(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 8;else return 7;
}
private int _7(){
    sp();
    System.out.print(String.valueOf((long)(sp()))+" ");
    return 15;
}
private int _8(){
    sa(sr());
    sa(sr());
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa((sp()!=0)?0:1);
    return 1;
}
private int _9(){
    t0=0;
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa(sr());
    return 10;
}
private int _10(){
    sa(sr());

    if(sp()!=0)return 14;else return 11;
}
private int _11(){
    x0=t0;
    sp();
    sa(sp()-t0);

    t1=sp();

    if((t1)!=0)return 12;else return 13;
}
private int _12(){
    sa(sr());
    sp();
    sa(sp()+x0);

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()-1L);

    sa(sr());
    sa((sp()!=0)?0:1);
    return 4;
}
private int _13(){
    sp();
    sp();
    return 6;
}
private int _14(){
    t0*=10;
    t1=sr()%10;
    x1=t1;
    t0+=x1;
    sa(sp()/10L);
    return 10;
}

public void main(){
    int c=0;
    while(c<15){
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
}
}
}
public static void main(String[]a){new Program().main();}
}
