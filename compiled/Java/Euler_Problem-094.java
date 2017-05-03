/* transpiled with BefunCompile v1.1.0 (c) 2015 */
class Program{
private java.io.BufferedReader ib=new java.io.BufferedReader(new java.io.InputStreamReader(System.in));
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0;
long x0=2;
long x1=0;
long x2=1000000000;
long x3=1;
private int _0(){
    return 1;
}
private int _1(){
    if(x2>(x0*2))return 3;else return 2;
}
private int _2()throws java.io.IOException{
    System.out.print(String.valueOf(x1));
    return 4;
}
private int _3(){
    x1=((x0>2?1:0)*(((tm(2*x0,3))-1!=0)?0:1)*((tm((x0-2)*x3,3)!=0)?0L:1L)*((x0*2)-2))+x1;
    x1=((((tm(x0*2,3))-2!=0)?0:1)*((tm((x0+2)*x3,3)!=0)?0L:1L)*(2+(2*x0)))+x1;
    t0=x0+(x3*2);
    x0=(x0*2)+(x3*3);
    x3=t0;
    return 1;
}

public void main()throws java.io.IOException{
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
public static void main(String[]a){try{new Program().main();}catch(java.io.IOException e){}}
}
