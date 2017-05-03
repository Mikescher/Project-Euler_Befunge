/* transpiled with BefunCompile v1.1.0 (c) 2015 */
class Program{
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1,t2,t3,t4,t5,t6,t7;
private int _0(){
    sa(0);
    sa(1);
    sa(1);
    sa(0);
    sa(5904);
    return 1;
}
private int _1(){
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+1L);

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr());
    return 2;
}
private int _2(){
    if(sp()!=0)return 13;else return 3;
}
private int _3(){
    sp();
    {long v0=sp();sa(sp()-v0);}

    t0=sp();

    if((t0)!=0)return 12;else return 4;
}
private int _4(){
    sa(sp()*59049L);
    return 5;
}
private int _5(){
    sa(sr());
    sa(sr());
    sa(tm(sr(),10));
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(sr());
    sa(sp()*sp());

    t0=sp();
    sa(sp()*t0);

    t1=sp();
    sa(td(sp(),10));

    sa(tm(sr(),10));
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(sr());
    sa(sp()*sp());

    t0=sp();
    sa(sp()*t0);

    t2=sp();
    sa(td(sp(),10));

    sa(tm(sr(),10));
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(sr());
    sa(sp()*sp());

    t0=sp();
    sa(sp()*t0);

    t3=sp();
    sa(td(sp(),10));

    sa(tm(sr(),10));
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(sr());
    sa(sp()*sp());

    t0=sp();
    sa(sp()*t0);

    t4=sp();
    sa(td(sp(),10));

    sa(tm(sr(),10));
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(sr());
    sa(sp()*sp());

    t0=sp();
    sa(sp()*t0);

    t5=sp();
    sa(td(sp(),10));

    sa(tm(sr(),10));
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(sr());
    sa(sp()*sp());

    t0=sp();
    sa(sp()*t0);

    t6=sp();
    sa(td(sp(),10));

    sa(tm(sp(),10));

    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(sr());
    sa(sp()*sp());

    t0=sp();
    sa(sp()*t0);

    t7=sp();
    t0=t7+t6;
    t6=t5+t0;
    t0=t4+t6;
    t4=t3+t0;
    t0=t2+t4;
    t2=t1+t0;
    sa(sp()-t2);

    t0=sp();

    if((t0)!=0)return 6;else return 11;
}
private int _6(){
    sa(sp()-1L);

    sa(sr());
    sa((sp()!=0)?0:1);

    if(sp()!=0)return 7;else return 5;
}
private int _7(){
    sp();
    sp();
    return 8;
}
private int _8(){
    sa(sp()+sp());

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr());

    if(sp()!=0)return 9;else return 10;
}
private int _9(){
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+sp());
    return 8;
}
private int _10(){
    sp();
    System.out.print(String.valueOf((long)(sp())));
    return 14;
}
private int _11(){
    sa(sr());
    return 6;
}
private int _12(){
    sa(sp()+1L);

    sa(sr());
    sa(sr()*59049);
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr());
    return 2;
}
private int _13(){
    sa(td(sp(),10));
    return 1;
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
