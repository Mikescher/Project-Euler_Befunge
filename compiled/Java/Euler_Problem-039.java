/* transpiled with BefunCompile v1.2.0 (c) 2017 */
class Program{
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0;
long x0=0;
long x1=0;
long x2=32;
long x3=6;
long x4=1000;
long x5=0;
private int _0(){
    x2=td(x3,3);
    return 1;
}
private int _1(){
    t0=x2;

    if(x2!=2)return 2;else return 4;
}
private int _2(){
    t0--;
    x2=t0;

    if(tm(x3*(x3-(2*x2)),(x3-x2)*2)!=0)return 1;else return 3;
}
private int _3(){
    x5++;
    return 1;
}
private int _4(){
    t0=x5;

    if(x5>x0)return 8;else return 5;
}
private int _5(){
    t0=x3;

    if(x3!=x4)return 7;else return 6;
}
private int _6(){
    System.out.print(String.valueOf(x1)+" ");
    return 9;
}
private int _7(){
    t0+=2;
    x3=t0;
    x5=0;
    x2=td(x3,3);
    return 1;
}
private int _8(){
    x0=t0;
    x1=x3;
    return 5;
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
