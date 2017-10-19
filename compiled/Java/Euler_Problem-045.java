/* transpiled with BefunCompile v1.3.0 (c) 2017 */
class Program{
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1,t2;
long x0=1152921504606846976L;
long x1=991873;
long x2=0;
private int _0(){
    sa(144);
    sa(991873);
    return 1;
}
private int _1(){
    sa(x0);
    sa(x0>x1?1:0);
    return 2;
}
private int _2(){
    if(sp()!=0)return 13;else return 3;
}
private int _3(){
    sa(sr());
    return 4;
}
private int _4(){
    if(sp()!=0)return 10;else return 5;
}
private int _5(){
    sp();
    sa(sp()-(x2*x2));


    if((x2%6)!=5)return 6;else return 7;
}
private int _6(){
    x2=0;
    sp();
    sa(sp()+1L);

    sa(sr());
    t0=(sr()*2)-1;
    sa(sp()*t0);

    sa(sp()*24L);

    sa(sp()+1L);

    x1=sr();
    return 1;
}
private int _7(){
    if(sp()!=0)return 8;else return 9;
}
private int _8(){
    x2=0;
    sa(sp()+1L);

    sa(sr());
    t0=(sr()*2)-1;
    sa(sp()*t0);

    sa(sp()*24L);

    sa(sp()+1L);

    x1=sr();
    return 1;
}
private int _9(){
    t0=(sr()*2)-1;
    sa(sp()*t0);

    t1=sp();
    System.out.print(String.valueOf(t1)+" ");
    return 14;
}
private int _10(){
    if((sr()+x2)>x1)return 11;else return 12;
}
private int _11(){
    x2/=2;
    sa(sp()/4L);

    sa(sr());
    return 4;
}
private int _12(){
    t0=sr()+x2;
    t1=x1;
    t2=t1-t0;
    x1=t2;
    t0=(sr()*2)+x2;
    x2=t0;
    x2/=2;
    sa(sp()/4L);
    return 3;
}
private int _13(){
    sa(sp()/4L);

    sa(sr()>x1?1:0);
    return 2;
}

public void main(){
    int c=0;
    while(c<14){
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
    case 13:c=_13();break;
}
}
}
public static void main(String[]a){new Program().main();}
}
