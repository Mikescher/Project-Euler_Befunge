/* transpiled with BefunCompile v1.3.0 (c) 2017 */
class Program{
private final static String _g = "Ah+LCAAAAAAABACT7+ZgAAEWhre3HLMPOQi0PdxvZLqX92LstCUbPD5c2mz7TcAk47DTRokjz76XnzlZNVGhq/377rObftueqa2e6B+pd9Ro9snjif/v5vV/+rc7m3/S"+
                                 "/Gdn1/2duD0oz6c+++BkS7FalwIiwbsHNiZ7f21e2S2V9fXk1I+ldXVrJ0XsCHme+Kb+QtYnU851n0N59Ewj92+bd27q4U7TZ/o3s2R1nauLpdrSF8/1vpb9ZdYy7olT"+
                                 "f/k5F7WuTSsKua2XeSLbelVp3dZX9f8YrET1bz7QZmAAAOh0xyzxAAAA";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[11232];for(int i=0;i<11232;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<104&&y<108)?g[(int)(y*104+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<104&&y<108)g[(int)(y*104+x)]=v;}
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1;
private int _0(){
    gw(3,0,100);
    sa(1);
    sa(1>gr(3,0)?1:0);
    return 1;
}
private int _1(){
    if(sp()!=0)return 9;else return 2;
}
private int _2(){
    sa(sr());
    gw(5,0,sp());
    gw(6,0,0);
    sa(1);
    sa(1-gr(5,0));
    return 3;
}
private int _3(){
    if(sp()!=0)return 4;else return 8;
}
private int _4(){
    t0=gr(5,0);
    sa(sr());
    sa(sr());
    sa(sr());
    sa(sr());
    sa(t0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    {long v0=sp();sa(sp()-v0);}

    t1=sp();
    sa((sp()>t1)?1:0);

    t0=sp();

    if((t0)!=0)return 7;else return 5;
}
private int _5(){
    sa(sr()+3);
    return 6;
}
private int _6(){
    t0=gr(5,0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(t0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    {long v0=sp();sa(sp()-v0);}

    sa(sp()+3L);

    {long v0=sp();sa(gr(sp(),v0));}
    sa(sp()+gr(6,0));

    sa(sr());
    gw(6,0,sp());
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+3L);

    sa(gr(5,0)+3);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sp()+1L);

    sa(sr()-gr(5,0));
    return 3;
}
private int _7(){
    t0=gr(5,0);
    sa(sr());
    sa(t0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    {long v0=sp();sa(sp()-v0);}

    sa(sp()+3L);
    return 6;
}
private int _8(){
    sp();
    sa(sr());
    sa(gr(6,0)+1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+3L);

    sa(sr());
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sp()+1L);

    sa(sr()>gr(3,0)?1:0);
    return 1;
}
private int _9(){
    sa(sp()+1L);

    sa(sr()+1);
    {long v0=sp();t0=gr(sp(),v0);}
    System.out.print(String.valueOf(t0)+" ");
    return 10;
}

public void main(){
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
public static void main(String[]a){new Program().main();}
}
