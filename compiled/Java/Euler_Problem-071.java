/* transpiled with BefunCompile v1.3.0 (c) 2017 */
class Program{
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0;
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
    sa(1);
    sa(0);
    return 1;
}
private int _1(){
    if(sp()!=0)return 5;else return 2;
}
private int _2(){
    x5=sr();
    t0=(sr()*3)/7;
    x6=t0;
    t0*=7;
    t0-=x5*3;

    if(t0>0)return 3;else return 8;
}
private int _3(){
    x7=t0;
    x8=x5*7;

    if((x4*x8)>(x3*x7))return 4;else return 5;
}
private int _4(){
    x4=x7;
    x3=x8;
    x0=x6;
    x2=x5;
    return 5;
}
private int _5(){
    if((sr()-x1)!=0)return 7;else return 6;
}
private int _6(){
    System.out.print(String.valueOf(x0)+" ");
    System.out.print(" /");
    System.out.print('\n');
    System.out.print(String.valueOf(x2)+" ");
    sp();
    return 9;
}
private int _7(){
    sa(sp()+1L);

    sa(((sr()*3)%7!=0)?0:1);
    return 1;
}
private int _8(){
    t0*=-1;
    return 3;
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
