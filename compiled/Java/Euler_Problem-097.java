/* transpiled with BefunCompile v1.3.0 (c) 2017 */
class Program{
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
private int _0(){
    sa(56866);
    sa(7830456);
    sa(7830456);
    return 1;
}
private int _1(){
    if(sp()!=0)return 3;else return 2;
}
private int _2(){
    sp();
    sa(sp()+1L);

    sa(sp()%10000000000L);

    System.out.print(String.valueOf((long)(sp()))+" ");
    return 4;
}
private int _3(){
    sa(sp()-1L);

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()*2L);

    sa(sp()%10000000000L);

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr());
    return 1;
}

public void main(){
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
public static void main(String[]a){new Program().main();}
}
