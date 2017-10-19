/* transpiled with BefunCompile v1.3.0 (c) 2017 */
class Program{
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0;
long x1=1;
long x2=88;
long x3=1;
long x4=88;
private int _0(){
    sa(10);
    sa(1);
    sa(1);
    sa(1);
    sa(1);
    return 1;
}
private int _1(){
    if(sp()!=0)return 12;else return 2;
}
private int _2(){
    x2=2;
    sp();
    sa((sr()*x2*10)/10);
    x4=1;
    return 3;
}
private int _3(){
    sa(sr());

    if(sp()!=0)return 11;else return 4;
}
private int _4(){
    sp();

    if((x4-x1)!=0)return 8;else return 5;
}
private int _5(){
    t0=x2-6;
    x2++;

    if((t0)!=0)return 7;else return 6;
}
private int _6(){
    System.out.print(String.valueOf((long)(sp()))+" ");
    sp();
    sp();
    return 13;
}
private int _7(){
    sa((sr()*x2*10)/10);
    x4=1;
    return 3;
}
private int _8(){
    sp();
    sa(sp()+1L);


    if(sr()<x3)return 10;else return 9;
}
private int _9(){
    sp();
    sa(sp()*10L);

    t0=sr()/6;
    x3=t0;
    x1=1;
    sa(sr()/10);
    sa(sr());
    sa((sr()*10)/10);
    sa(sr());
    return 1;
}
private int _10(){
    x1=1;
    sa(sr());
    sa((sr()*10)/10);
    sa(sr());
    return 1;
}
private int _11(){
    t0=((sr()%10)+2)*x4;
    x4=t0;
    sa(sp()/10L);
    return 3;
}
private int _12(){
    t0=((sr()%10)+2)*x1;
    x1=t0;
    sa(sp()/10L);

    sa(sr());
    return 1;
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
