/* transpiled with BefunCompile v1.2.0 (c) 2017 */
class Program{
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1,t2;
long x0=1;
long x1=1;
long x2=0;
long x3=0;
private int _0(){
    return 1;
}
private int _1(){
    t0=x0;
    t1=x2;
    x0=(x0*3)+(x2*4);
    t1*=3;
    t0*=2;
    t2=t1+t0;
    x2=t2;
    t0=x1;
    t1=x3;
    x1=(x1*3)-(x3*4);
    t1*=3;
    t0*=2;
    t2=t1-t0;
    x3=t2;
    return 2;
}
private int _2(){
    if((td((2+(x2*2))-x0-(2*x3)-x1,4))<=1000000000000L)return 1;else return 3;
}
private int _3(){
    System.out.print(String.valueOf(td((4+(x1*2)+(x3*2)+(x0*2))-(x2*2),8))+" ");
    return 4;
}

public void main(){
    int c=0;
    while(c<4){
    switch(c){
    case 0:c=_0();break;
    case 1:c=_1();break;
    case 2:c=_2();break;
    case 3:c=_3();break;
}
}
}
public static void main(String[]a){new Program().main();}
}
