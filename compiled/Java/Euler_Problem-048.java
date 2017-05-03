/* transpiled with BefunCompile v1.1.0 (c) 2015 */
class Program{
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0;
long x0=10000000000L;
long x1=32;
long x2=32;
private int _0(){
    sa(0);
    sa(1000);
    return 1;
}
private int _1(){
    x2=sr();
    sa(sr());
    x1=sr();
    return 2;
}
private int _2(){
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 5;else return 3;
}
private int _3(){
    sp();
    sp();
    sa(sp()+x1);

    sa(tm(sp(),x0));

    sa(x2-1);

    if(x2!=1)return 1;else return 4;
}
private int _4(){
    sp();
    System.out.print(String.valueOf((long)(sp())));
    return 6;
}
private int _5(){
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    t0=tm(sr()*x1,x0);
    x1=t0;
    return 2;
}

public void main(){
    int c=0;
    while(c<6){
    switch(c){
    case 0:c=_0();break;
    case 1:c=_1();break;
    case 2:c=_2();break;
    case 3:c=_3();break;
    case 4:c=_4();break;
    case 5:c=_5();break;
}
}
}
public static void main(String[]a){new Program().main();}
}
