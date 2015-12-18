/* compiled with BefunCompile v1.0.8 (c) 2015 */
public static class Program 
{
private static readonly string _g = "AR+LCAAAAAAABADt28tSpDAUgOFXiYIbUow5BBRTVGreYLazoGh22WbFaubdJ9Ci7aV1yrlg6/91VYtJ7IqLJOccmkl9TxSAT+lbsvUcAADA/5QBAAAAAAAAAAAAAAAA"+
                                    "AAAAAIB3b+vnDwBsZ+v9BwAAAAAAAAAAAAAAAAAAAAAAvG7r5w8AnIYp6la3l8E0/UV6c724qO1lt/W8ALyNPx9Hda6LysTzn+N5YU1sXbF/1SZWbTG/mnRlgndn2bST"+
                                    "0tUm9K4x4aJPb2rY+n8A8EZTlLqKYrUEY6NUVTrkW6mOjM67yZVlkDqITePTBac/cLqm413PLu1HFYPdkJVW63HeElIucJcbzJvE8a2hiw/GsocA2/BWgmgrUZm2KoJz"+
                                    "tYT+shdd1Eqi6Lk1mib1K5+60mhrQiWh1GNKBtJ1akntZSnjvns8u21UQ2q9SxMurZ7HjVrbMht29fI5t39LBgG8O8N6Sq8N82l9eFZ71Ui4X+Fpp9Bhv3/UEu0LkQWA"+
                                    "dyHl/03K/aWZawB9Suuj1EX6Wbugi+qg2h9ENfFxU/No0PpJZf9S+A/gffDNEomLLlM4/7Dr8QH+SpjOegdOTVrk++q/WBYw8Mn4Z1J4J/pJa1RrYi86XRXpIo2pJIxr"+
                                    "3EAVDzgxU7RiojXmmb7fjQf8shFE1j9w6rzV4Wq+JXh45y5eLeGAmtMFn+dU9oEPw0uc/LWEUqlsUtPTZ4IOAoHUme+mbOyDtNQLgNN3PZlucMvX97qUxR/e37taWtX9"+
                                    "7T0X5cp1yrdpu/ix9cQB/BFvpBy8W4P9QU273Jn16R61j/4PBizf43NuWfr51pMH8OeGFNGXwVTpfO+8u97X9FuJzkvpRCt1f9Jnc5k/z5fQXzabMIC/6O4ovy3i5z5T"+
                                    "19m8xGOmurwzSj14ZKdPDZr8Hzh9kzFHlvL6BMD6e3/Bmgc+lkkfjeRZ7sAH5527kXhY4NM3Epw1lPiBz8znX/KvW08CwL/xC0UCinQAyAAA";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<1024&&y<50)?g[y*1024+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<1024&&y<50)g[y*1024+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[] args)
{
        long t0,t1,t2,t3,t4;
        gw(2,0,12288);
        gw(3,0,12000);
        gw(4,0,281474976710656L);
        gw(5,0,1024);
        sa(gr(2,0));
        sa(((gr(2,0))!=0)?0:1);
    _1:
        if(sp()!=0)goto _2;else goto _31;
    _2:
        gw(1,16,2);
        gw(2,1,2);
        gw(3,1,gr(3,0)+1);
        gw(4,1,2);
        gw(3,1,gr(3,1)+1);
        sp();
    _3:
        t0=gr(0,16);
        gw(4,1,(td(gr(4,1),gr(0,16)))*(gr(0,16)+1));
        t0++;
        gw(0,16,t0);
        gw(5,1,0);
    _4:
        if(gr(4,1)>(gr(3,1)+(gr(3,0)-gr(2,1))))goto _5;else goto _28;
    _5:
        t0=gr(tm(gr(5,1),gr(5,0)),(td(gr(5,1),gr(5,0)))+16);
        gw(4,1,td(gr(4,1),gr(tm(gr(5,1),gr(5,0)),(td(gr(5,1),gr(5,0)))+16)));
        t1=gr(3,1);
        t2=t1-t0;
        gw(3,1,t2);
        gw(tm(gr(5,1),gr(5,0)),(td(gr(5,1),gr(5,0)))+16,gr(tm(gr(5,1)+1,gr(5,0)),(td(gr(5,1)+1,gr(5,0)))+16));
        t0=gr(tm(gr(5,1),gr(5,0)),(td(gr(5,1),gr(5,0)))+16);
        gw(4,1,gr(4,1)*gr(tm(gr(5,1),gr(5,0)),(td(gr(5,1),gr(5,0)))+16));
        t1=gr(3,1);
        t2=t1+t0;
        gw(3,1,t2);
        gw(5,1,gr(5,1)+1);
        if(gr(5,1)!=(gr(3,0)+1))goto _6;else goto _8;
    _6:
        gw(3,1,gr(3,1)+1);
        t0=gr(tm(gr(5,1),gr(5,0)),(td(gr(5,1),gr(5,0)))+16);
        t1=gr(tm(gr(5,1),gr(5,0)),(td(gr(5,1),gr(5,0)))+16);
        gw(tm(gr(5,1),gr(5,0)),(td(gr(5,1),gr(5,0)))+16,gr(tm(gr(5,1),gr(5,0)),(td(gr(5,1),gr(5,0)))+16)+1);
        t2=gr(4,1);
        t3=td(t2,t1);
        gw(4,1,t3);
        t0++;
        t0*=gr(4,1);
        gw(4,1,t0);
        if(gr(5,1)>gr(2,1))goto _7;else goto _4;
    _7:
        gw(2,1,gr(5,1));
        goto _4;
    _8:
        gw(0,3,0);
        gw(1,3,0);
        gw(7,1,-1);
        sa(5);
        sa(0);
        sa(gr(0,3));
        sa(gr(0,3)-gr(7,1));
    _9:
        if(sp()!=0)goto _17;else goto _10;
    _10:
        sp();
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(tm(sr(),gr(5,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(5,0)));
        sa(sp()+3L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    _11:
        sa(sp()+1L);
        if(sr()!=gr(2,0))goto _12;else goto _13;
    _12:
        sa(sr());
        sa(tm(sr(),gr(5,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(5,0)));
        sa(sp()+3L);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sr()-gr(7,1));
        goto _9;
    _13:
        gw(9,1,0);
        sp();
        t4=gr(0,3);
    _14:
        sa(gr(9,1));
        if(gr(9,1)!=gr(3,0))goto _16;else goto _15;
    _15:
        sp();
        System.Console.Out.Write(t4);
        sp();
        return;
    _16:
        sa(sp()+1L);
        sa(sr());
        sa(sr());
        gw(9,1,sp());
        sa(tm(sp(),gr(5,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(5,0)));
        sa(sp()+3L);
        {long v0=sp();t0=gr(sp(),v0);}
        t4+=t0;
        goto _14;
    _17:
        if(sr()>gr(7,1))goto _18;else goto _19;
    _18:
        gw(7,1,sp());
        goto _11;
    _19:
        gw(8,1,sp());
        sa(sr());
    _20:
        sa(sp()-1L);
        if((sr()+1)!=0)goto _21;else goto _24;
    _21:
        sa(sr());
        sa(tm(sr(),gr(5,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(5,0)));
        sa(sp()+3L);
        {long v0=sp();sa(gr(sp(),v0));}
        sa(sr());
        sa(sr());
        if(sp()!=0)goto _22;else goto _27;
    _22:
        sa(sp()-gr(8,1));
        if(sp()!=0)goto _23;else goto _26;
    _23:
        sa((sp()<gr(8,1))?1:0);
        if(sp()!=0)goto _24;else goto _25;
    _24:
        sp();
        goto _11;
    _25:
        sa(sr());
        gw(6,1,sp());
        sa(sr()+1);
        sa(tm(sr(),gr(5,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(5,0)));
        sa(sp()+3L);
        {long v0=sp();t0=gr(sp(),v0);}
        gw(tm(gr(6,1)+1,gr(5,0)),(td(gr(6,1)+1,gr(5,0)))+3,gr(tm(gr(6,1),gr(5,0)),(td(gr(6,1),gr(5,0)))+3));
        gw(tm(gr(6,1),gr(5,0)),(td(gr(6,1),gr(5,0)))+3,t0);
        goto _20;
    _26:
        sp();
        sa(sp()+1L);
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(tm(sr(),gr(5,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(5,0)));
        sa(sp()+3L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _11;
    _27:
        sp();
        sp();
        goto _25;
    _28:
        if((((gr(3,0)-(gr(3,1)-gr(4,1)))>1?1:0)+(gr(4,1)<=gr(3,1)?1:0)+(gr(tm(gr(3,0)-(gr(3,1)-gr(4,1)),gr(5,0)),(td(gr(3,0)-(gr(3,1)-gr(4,1)),gr(5,0)))+3)>gr(4,1)?1L:0L))!=3)goto _29;else goto _30;
    _29:
        gw(3,1,gr(3,1)+1);
        goto _3;
    _30:
        gw(tm(gr(3,0)-(gr(3,1)-gr(4,1)),gr(5,0)),(td(gr(3,0)-(gr(3,1)-gr(4,1)),gr(5,0)))+3,gr(4,1));
        gw(3,1,gr(3,1)+1);
        goto _3;
    _31:
        sa(sp()-1L);
        sa(sr());
        sa(gr(4,0));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(tm(sr(),gr(5,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(5,0)));
        sa(sp()+3L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(tm(sr(),gr(5,0)));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),gr(5,0)));
        sa(sp()+8L);
        sa(sp()+8L);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        sa((sp()!=0)?0:1);
        goto _1;
}}