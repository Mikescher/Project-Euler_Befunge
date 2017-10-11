/* transpiled with BefunCompile v1.2.0 (c) 2017 */
class Program{
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1,t2;
long x0=1073741824;
long x1=2;
long x2=37;
long x3=37;
long x4=37;
long x5=5;
long x6=37;
private int _0(){
    sa(2);
    sa(5);
    return 1;
}
private int _1(){
    sa(x1-1);
    sa(x1-1);
    return 2;
}
private int _2(){
    if(sp()!=0)return 4;else return 3;
}
private int _3(){
    sp();
    sp();
    sa(sp()+1L);

    sa(sr());
    x1=sr();
    t0=(sr()*3)-1;
    sa(sp()*t0);

    sa(td(sp(),2));

    x5=sr();
    return 1;
}
private int _4(){
    x2=sr();
    t0=(sr()*3)-1;
    sa(sp()*t0);

    t1=sp();
    t1/=2;
    x3=t1;
    x6=0;
    sa(sp()-t1);

    sa(sp()*24L);

    sa(sp()+1L);

    x4=sr();
    sa(x0);
    sa(x0>x4?1:0);
    return 5;
}
private int _5(){
    if(sp()!=0)return 25;else return 6;
}
private int _6(){
    sa(sr());
    return 7;
}
private int _7(){
    if(sp()!=0)return 22;else return 8;
}
private int _8(){
    sp();
    sa(sp()-(x6*x6));

    t0=x6;

    if(sp()!=0)return 17;else return 9;
}
private int _9(){
    t0%=6;
    t0-=5;
    t0=(t0!=0)?0:1;

    if((t0)!=0)return 10;else return 17;
}
private int _10(){
    sa(((x3+x5)*24)+1);
    t0=((x3+x5)*24)+1;
    x6=0;
    x4=t0;
    sa(x0);
    sa(x0>x4?1:0);
    return 11;
}
private int _11(){
    if(sp()!=0)return 21;else return 12;
}
private int _12(){
    sa(sr());
    return 13;
}
private int _13(){
    if(sp()!=0)return 18;else return 14;
}
private int _14(){
    sp();
    sa(sp()-(x6*x6));

    t0=x6;

    if(sp()!=0)return 17;else return 15;
}
private int _15(){
    t0%=6;
    t0-=5;

    if((t0)!=0)return 17;else return 16;
}
private int _16(){
    System.out.print(String.valueOf(x5-x3)+" ");
    sp();
    return 26;
}
private int _17(){
    sa(x5);
    sa(x2-1);
    sa(x2-1);
    return 2;
}
private int _18(){
    if((sr()+x6)<=x4)return 20;else return 19;
}
private int _19(){
    x6/=2;
    sa(td(sp(),4));

    sa(sr());
    return 13;
}
private int _20(){
    t0=sr()+x6;
    t1=x4;
    t2=t1-t0;
    x4=t2;
    t0=(sr()*2)+x6;
    x6=t0;
    x6/=2;
    sa(td(sp(),4));
    return 12;
}
private int _21(){
    sa(td(sp(),4));

    sa(sr()>x4?1:0);
    return 11;
}
private int _22(){
    if((sr()+x6)<=x4)return 24;else return 23;
}
private int _23(){
    x6/=2;
    sa(td(sp(),4));

    sa(sr());
    return 7;
}
private int _24(){
    t0=sr()+x6;
    t1=x4;
    t2=t1-t0;
    x4=t2;
    t0=(sr()*2)+x6;
    x6=t0;
    x6/=2;
    sa(td(sp(),4));
    return 6;
}
private int _25(){
    sa(td(sp(),4));

    sa(sr()>x4?1:0);
    return 5;
}

public void main(){
    int c=0;
    while(c<26){
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
    case 14:c=_14();break;
    case 15:c=_15();break;
    case 16:c=_16();break;
    case 17:c=_17();break;
    case 18:c=_18();break;
    case 19:c=_19();break;
    case 20:c=_20();break;
    case 21:c=_21();break;
    case 22:c=_22();break;
    case 23:c=_23();break;
    case 24:c=_24();break;
    case 25:c=_25();break;
}
}
}
public static void main(String[]a){new Program().main();}
}
