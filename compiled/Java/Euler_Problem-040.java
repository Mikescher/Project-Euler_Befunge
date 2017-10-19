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
long x2=1;
private int _0(){
    t0=1;
    sa(0);
    sa(1);
    sa(10);
    sa(100);
    sa(1000);
    sa(10000);
    sa(100000);
    sa(1000000);
    sa(1000000);
    return 1;
}
private int _1(){
    if(sp()!=0)return 3;else return 2;
}
private int _2(){
    System.out.print(String.valueOf(x2)+" ");
    sp();
    return 11;
}
private int _3(){
    x0=1;
    x1=1;
    return 4;
}
private int _4(){
    if(sr()>(x0*9*x1))return 10;else return 5;
}
private int _5(){
    sa(sp()-1L);

    t0=(td(sr(),x0))+x1;
    sa(tm(sp(),x0));

    t1=x0;
    sa(t1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    {long v0=sp();sa(sp()-v0);}

    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 9;else return 6;
}
private int _6(){
    sa(sr());
    return 7;
}
private int _7(){
    if(sp()!=0)return 9;else return 8;
}
private int _8(){
    t0%=10;
    t0*=x2;
    x2=t0;
    sp();
    sa(sr());
    return 1;
}
private int _9(){
    t0/=10;
    sa(sp()-1L);

    sa(sr());
    return 7;
}
private int _10(){
    sa(sp()-(x0*9*x1));

    x0++;
    x1*=10;
    return 4;
}

public void main(){
    int c=0;
    while(c<11){
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
}
}
}
public static void main(String[]a){new Program().main();}
}
