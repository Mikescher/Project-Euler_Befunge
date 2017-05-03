/* transpiled with BefunCompile v1.1.0 (c) 2015 */
class Program{
private final static String _g = "AR+LCAAAAAAABACtk7FygzAMQH/FQLpEcU8WEDBHff2MDrkkm1dPnvj4ynYAtyVtL60GnZAt6UkW/m0W8bD4f8jxH2I0kkNFTpsBT8r5P2WbTlINYnyEQ5FtWziIaidK"+
                                 "8VIeDuJZvP4y2DtCLjpdtSUMjgcIxo0os8NlHkbcH41BJIu2xFIqJ7xZvgZ9nfh4IHLcnJyEIbLKxqDKX0S6qMtrUZ0vS7qq+lTLKDivtSapHRGowRKNoXWpuG2HrICL"+
                                 "stexg9Toiyv78DetZ8IJISQcA8d3YkTO7y8bV5gafiyfZcznWL6V4ctxDsVHXIBP3UYU1rzBvL0xrg5r5HmbnPlIYlMBsloWrPuoO1kALLPmwZ54rI5q2MO4AU5Bba7B"+
                                 "MkKzY4LhOawyb/T5602cOY6yS8h8d98nE4Ktb3av4QkKbwB4OT5MOqb1BR+3Pcjw5tjvQ2yyu2An8yjb8JTgeZpOJV/YibESM0cj25XjmHHc8KDpIgfEtXasFKSHSN1F"+
                                 "jg5vtY8ZR7tyNLKOHHcfnizJeuVoMo4bHmCbOO7kiBz1zNFkHPXKQfFf+ZaDf6eVgzKOeuagwGE23pblHVzPp+QcBgAA";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[1564];for(int i=0;i<1564;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<68&&y<23)?g[(int)(y*68+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<68&&y<23)g[(int)(y*68+x)]=v;}
private java.io.BufferedReader ib=new java.io.BufferedReader(new java.io.InputStreamReader(System.in));
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0;
private int _0(){
    gw(0,2,9);
    gw(1,2,0);
    gw(9,1,0);
    sa(8);
    return 1;
}
private int _1(){
    sa(sr());
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(1);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr()-1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    return 2;
}
private int _2(){
    if(sp()!=0)return 1;else return 3;
}
private int _3(){
    sp();
    return 4;
}
private int _4(){
    if(gr(0,2)>9)return 25;else return 5;
}
private int _5(){
    sa(gr(gr(0,2),0)-48);

    if((gr(gr(0,2),0)-48)>9)return 24;else return 6;
}
private int _6(){
    sa(sp()+1L);

    sa(sr());
    gw(2,2,sp());
    sa(sp()-10L);


    if(sp()!=0)return 19;else return 7;
}
private int _7(){
    if(gr(gr(0,2),0)<=57)return 18;else return 8;
}
private int _8(){
    gw(0,2,gr(0,2)+1);
    return 9;
}
private int _9(){
    if(0<=gr(0,2))return 14;else return 10;
}
private int _10(){
    gw(0,2,0);
    gw(3,2,0);
    gw(3,2,(gr(0,0)-48)+(gr(3,2)*10));
    sa(1);
    return 11;
}
private int _11(){
    sa(sr());
    sa(0);
    {long v0=sp();t0=gr(sp(),v0);}
    t0-=48;
    t0+=gr(3,2)*10;
    gw(3,2,t0);
    sa(sr()+1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()-9L);
    return 12;
}
private int _12(){
    if(sp()!=0)return 11;else return 13;
}
private int _13()throws java.io.IOException{
    sp();
    t0=gr(3,2);
    System.out.print(String.valueOf(gr(3,2)));
    System.out.print('\n');
    t0+=gr(1,2);
    gw(1,2,t0);
    return 4;
}
private int _14(){
    if((((gr(0,2)-9!=0)?0:1)+((gr(0,2)-8!=0)?0:1)+((gr(0,2)-7!=0)?0L:1L)+(((gr(0,2)-6)+(tm(((((gr(7,0)-48)*10)+(gr(8,0)-48))*10)+(gr(9,0)-48),17))!=0)?0:1)+(((gr(0,2)-5)+(tm(((((gr(6,0)-48)*10)+(gr(7,0)-48))*10)+(gr(8,0)-48),13))!=0)?0:1)+(((gr(0,2)-4)+(tm(((((gr(5,0)-48)*10)+(gr(6,0)-48))*10)+(gr(7,0)-48),11))!=0)?0:1)+(((gr(0,2)-3)+(tm(((((gr(4,0)-48)*10)+(gr(5,0)-48))*10)+(gr(6,0)-48),7))!=0)?0:1)+(((gr(0,2)-2)+(tm(((((gr(3,0)-48)*10)+(gr(4,0)-48))*10)+(gr(5,0)-48),5))!=0)?0:1)+(((gr(0,2)-1)+(tm(((((gr(2,0)-48)*10)+(gr(3,0)-48))*10)+(gr(4,0)-48),3))!=0)?0:1)+((gr(0,2)+(tm(((((gr(1,0)-48)*10)+(gr(2,0)-48))*10)+(gr(3,0)-48),2))!=0)?0L:1L))!=0)return 4;else return 15;
}
private int _15(){
    if(gr(gr(0,2),0)<=57)return 17;else return 16;
}
private int _16(){
    gw(0,2,gr(0,2)+1);
    return 4;
}
private int _17(){
    gw(gr(gr(0,2),0)-48,1,0);
    gw(gr(0,2),0,88);
    gw(0,2,gr(0,2)+1);
    return 4;
}
private int _18(){
    gw(gr(gr(0,2),0)-48,1,0);
    gw(gr(0,2),0,88);
    return 8;
}
private int _19(){
    if((gr(gr(2,2),1))!=0)return 20;else return 21;
}
private int _20(){
    t0=gr(2,2);
    gw(2,2,gr(2,2)+1);
    t0-=9;

    if((t0)!=0)return 19;else return 7;
}
private int _21(){
    if(gr(gr(0,2),0)<=57)return 23;else return 22;
}
private int _22(){
    gw(gr(2,2),1,1);
    gw(gr(0,2),0,gr(2,2)+48);
    gw(0,2,gr(0,2)-1);
    return 9;
}
private int _23(){
    gw(gr(gr(0,2),0)-48,1,0);
    return 22;
}
private int _24(){
    gw(2,2,0);
    sp();
    return 19;
}
private int _25()throws java.io.IOException{
    t0=gr(1,2);
    System.out.print('\n');
    System.out.print("= ");
    System.out.print(String.valueOf(t0));
    return 26;
}

public void main()throws java.io.IOException{
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
public static void main(String[]a){try{new Program().main();}catch(java.io.IOException e){}}
}
