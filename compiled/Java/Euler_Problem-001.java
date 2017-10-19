/* transpiled with BefunCompile v1.3.0 (c) 2017 */
class Program{
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1;
private int _0(){
    sa(1);
    sa(1);
    sa(1);
    return 1;
}
private int _1(){
    sp();
    sa(sp()+1L);

    sa(sr());
    sa(sr());
    t0=(sr()/3)*3;
    sa(sp()-t0);

    t1=sp();

    if((t1)!=0)return 2;else return 3;
}
private int _2(){
    sa(sr());
    t0=(sr()/5)*5;
    sa(sp()-t0);

    t1=sp();

    if((t1)!=0)return 4;else return 3;
}
private int _3(){
    sa(sr());
    return 4;
}
private int _4(){
    if(sr()!=1000)return 1;else return 5;
}
private int _5(){
    sp();
    sp();
    sp();
    return 6;
}
private int _6(){
    sa(sp()+sp());

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}

    if(sr()!=1)return 8;else return 7;
}
private int _7(){
    sp();
    System.out.print(String.valueOf((long)(sp()))+" ");
    return 9;
}
private int _8(){
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    return 6;
}

public void main(){
    int c=0;
    while(c<9){
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
}
}
}
public static void main(String[]a){new Program().main();}
}
