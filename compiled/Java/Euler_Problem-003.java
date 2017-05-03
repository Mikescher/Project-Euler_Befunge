/* transpiled with BefunCompile v1.1.0 (c) 2015 */
class Program{
private java.io.BufferedReader ib=new java.io.BufferedReader(new java.io.InputStreamReader(System.in));
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1,t2;
long x0=775146;
long x1=600851475143L;
long x2=55;
long x3=57;
private int _0(){
    return 1;
}
private int _1(){
    t0=x1;
    t1=x0-1;
    x0--;
    t2=tm(t0,t1);
    return 2;
}
private int _2(){
    if((t2)!=0)return 1;else return 3;
}
private int _3(){
    t0=x0;
    x3=x0;
    t0--;
    x2=t0;
    return 4;
}
private int _4(){
    if(tm(x3,x2)==0)return 1;else return 5;
}
private int _5(){
    t0=x2;
    x2--;
    t0-=2;

    if((t0)!=0)return 4;else return 6;
}
private int _6()throws java.io.IOException{
    System.out.print(String.valueOf(x3));
    return 7;
}

public void main()throws java.io.IOException{
    int c=0;
    while(c<7){
    switch(c){
    case 0:c=_0();break;
    case 1:c=_1();break;
    case 2:c=_2();break;
    case 3:c=_3();break;
    case 4:c=_4();break;
    case 5:c=_5();break;
    case 6:c=_6();break;
}
}
}
public static void main(String[]a){try{new Program().main();}catch(java.io.IOException e){}}
}
