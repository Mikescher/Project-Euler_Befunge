/* transpiled with BefunCompile v1.3.0 (c) 2017 */
class Program{
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0;
long x0=2000000;
long x1=2000000;
long x2=0;
long x3=89;
long x4=0;
long x5=89;
long x6=89;
private int _0(){
    return 1;
}
private int _1(){
    if(x0>x4)return 3;else return 2;
}
private int _2(){
    System.out.print(String.valueOf(x3)+" ");
    return 12;
}
private int _3(){
    x5=1;
    x6=x4;
    return 4;
}
private int _4(){
    if(((x2>x5?1:0)*(x0>x6?1L:0L))!=0)return 5;else return 11;
}
private int _5(){
    sa(x0-x6);

    if((x0-x6)<0)return 10;else return 6;
}
private int _6(){
    sa(sp()-0L);
    return 7;
}
private int _7(){
    if(sr()>x1)return 9;else return 8;
}
private int _8(){
    x1=sp();
    x3=x5*x2;
    sa(0);
    return 9;
}
private int _9(){
    t0=x5+1;
    x5++;
    t0*=x4;
    t0+=x6;
    x6=t0;
    sp();
    return 4;
}
private int _10(){
    t0=0;
    sa(t0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    {long v0=sp();sa(sp()-v0);}
    return 7;
}
private int _11(){
    t0=x2+1;
    x2++;
    t0+=x4;
    x4=t0;
    return 1;
}

public void main(){
    int c=0;
    while(c<12){
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
}
}
}
public static void main(String[]a){new Program().main();}
}
