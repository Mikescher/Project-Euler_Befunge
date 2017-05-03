/* transpiled with BefunCompile v1.1.0 (c) 2015 */
class Program{
private java.io.BufferedReader ib=new java.io.BufferedReader(new java.io.InputStreamReader(System.in));
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1;
long x0=0;
long x1=1000000;
long x2=0;
long x3=1;
long x4=1;
long x5=63;
long x6=63;
long x7=63;
long x8=63;
private int _0(){
    t0=1;
    return 1;
}
private int _1(){
    x5=t0;
    t1=td(t0*3,7);
    x6=t1;
    t1*=7;
    t1-=x5*3;

    if(t1>0)return 2;else return 7;
}
private int _2(){
    x7=t1;
    x8=x5*7;

    if((x4*x8)>(x3*x7))return 3;else return 4;
}
private int _3(){
    x4=x7;
    x3=x8;
    x0=x6;
    x2=x5;
    return 4;
}
private int _4(){
    if(t0!=x1)return 5;else return 6;
}
private int _5(){
    t0++;

    if(tm(t0*3,7)==0)return 4;else return 1;
}
private int _6()throws java.io.IOException{
    System.out.print(String.valueOf(x0));
    System.out.print(" /");
    System.out.print('\n');
    System.out.print(String.valueOf(x2));
    return 8;
}
private int _7(){
    t1*=-1;
    return 2;
}

public void main()throws java.io.IOException{
    int c=0;
    while(c<8){
    switch(c){
    case 0:c=_0();break;
    case 1:c=_1();break;
    case 2:c=_2();break;
    case 3:c=_3();break;
    case 4:c=_4();break;
    case 5:c=_5();break;
    case 6:c=_6();break;
    case 7:c=_7();break;
}
}
}
public static void main(String[]a){try{new Program().main();}catch(java.io.IOException e){}}
}
