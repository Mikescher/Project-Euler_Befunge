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
long x0=20;
long x1=1;
long x2=1;
long x3=48;
long x4=48;
long x5=112;
private int _0(){
    return 1;
}
private int _1(){
    x1*=x2;
    t0=x0;
    t1=x2+1;
    x2++;
    t2=t0>t1?1:0;

    if((t2)!=0)return 3;else return 2;
}
private int _2()throws java.io.IOException{
    System.out.print(String.valueOf(x1));
    return 10;
}
private int _3(){
    x3=1;
    return 4;
}
private int _4(){
    t0=x3;
    x3++;
    t0=t0>x0?1:0;

    if((t0)!=0)return 1;else return 5;
}
private int _5(){
    if(tm(x1,x3)!=0)return 4;else return 6;
}
private int _6(){
    x4=td(x1,x3);
    x5=1;
    return 7;
}
private int _7(){
    t0=x2;
    t1=x5+1;
    x5++;
    t2=t0>t1?1:0;

    if((t2)!=0)return 9;else return 8;
}
private int _8(){
    x1/=x3;
    return 5;
}
private int _9(){
    if(tm(x4,x5)==0)return 7;else return 4;
}

public void main()throws java.io.IOException{
    int c=0;
    while(c<10){
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
}
}
}
public static void main(String[]a){try{new Program().main();}catch(java.io.IOException e){}}
}
