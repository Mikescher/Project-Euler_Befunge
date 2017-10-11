/* transpiled with BefunCompile v1.2.0 (c) 2017 */
class Program{
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1,t2,t3;
long x0=1000;
long x1=2;
long x2=34;
long x3=53;
private int _0(){
    return 1;
}
private int _1(){
    x2=1;
    return 2;
}
private int _2(){
    sa((x2*x2)+(x1*x1));
    x3=(x2*x2)+(x1*x1);
    sa(0);
    sa(0-x3);
    return 3;
}
private int _3(){
    if(sp()!=0)return 4;else return 10;
}
private int _4(){
    sa(sp()+1L);


    if(sr()!=x0)return 9;else return 5;
}
private int _5(){
    sp();
    sp();
    return 6;
}
private int _6(){
    t0=x2+1;
    x2++;
    t0-=x1;

    if((t0)!=0)return 2;else return 7;
}
private int _7(){
    t0=x1+1;
    x1++;
    t0-=x0;

    if((t0)!=0)return 1;else return 8;
}
private int _8(){
    return 13;
}
private int _9(){
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(sp()-x3);
    return 3;
}
private int _10(){
    x3=sr();
    sa(sp()+x2+x1);

    sa(sp()-x0);


    if(sp()!=0)return 11;else return 12;
}
private int _11(){
    sp();
    return 6;
}
private int _12(){
    t0=x2;
    System.out.print(String.valueOf(x2)+" ");
    System.out.print(' ');
    t1=x1;
    System.out.print(String.valueOf(x1)+" ");
    System.out.print(' ');
    t2=x3;
    System.out.print(String.valueOf(x3)+" ");
    System.out.print('=');
    t3=t1*t2;
    t1=t0*t3;
    System.out.print(String.valueOf(t1)+" ");
    return 13;
}

public void main(){
    int c=0;
    while(c<13){
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
    case 12:c=_12();break;
}
}
}
public static void main(String[]a){new Program().main();}
}
