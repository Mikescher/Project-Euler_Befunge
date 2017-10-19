/* transpiled with BefunCompile v1.3.0 (c) 2017 */
class Program{
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long x0=0;
long x1=32;
private int _0(){
    sa(4);
    sa(1);
    sa(4);
    sa(0);
    return 1;
}
private int _1(){
    if(sp()!=0)return 11;else return 2;
}
private int _2(){
    sa(sp()/2L);
    return 3;
}
private int _3(){
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+1L);

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}

    if(sr()!=1)return 10;else return 4;
}
private int _4(){
    sp();

    if(sr()<x0)return 5;else return 9;
}
private int _5(){
    sp();
    return 6;
}
private int _6(){
    if(sr()>1000000)return 7;else return 8;
}
private int _7(){
    System.out.print(String.valueOf(x1)+" ");
    System.out.print(" :");
    System.out.print(String.valueOf(x0)+" ");
    return 12;
}
private int _8(){
    sa(sp()+1L);

    sa(sr());
    sa(1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr()%2);
    return 1;
}
private int _9(){
    x0=sp();
    x1=sr();
    return 6;
}
private int _10(){
    sa(sp()/1L);

    sa(sr()%2);
    return 1;
}
private int _11(){
    sa(sp()*3L);

    sa(sp()+1L);
    return 3;
}

public void main(){
    int c=0;
    while(c<12){
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
}
}
}
public static void main(String[]a){new Program().main();}
}
