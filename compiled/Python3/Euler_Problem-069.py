#!/usr/bin/env python3

# transpiled with BefunCompile v1.2.0 (c) 2017
import gzip, base64
_g = ("AR+LCAAAAAAABADlUE1rwzAM/SvCTS8OaaTmc8aEXnbvcYfgho0gGB0VZfOp/e9TtpX2kELve2CBZOk9PUX8ASjyHLbHw/v49gnPX/vxCNmUv+7HD6if4EEs/hni7BU6"
  + "qZAprVDm/+ewWTE2fr4/EKP/ZS4mYleglMjZ5ehxZ87njbG2RtEcO0fcINuYdNSgmK1xhFK4NYotUdY6HkPFWOzCIjNgOKWckfqlBqdlL6i7Y/EnCiElH7F2PomCrW2t"
  + "dW56rRAJoVMK/4hHlRuUnrH00PEAcOrMi1FLuh4vew05paL5ZDN1arEfrh6Tq/nbflb17BQARO93RzjIrcNeJ5y2hvubXoi+AR19dk8gAwAA")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<80 and y<10):
        return g[y*80 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<80 and y<10):
        g[y*80 + x]=v;
def td(a,b):
    return ((0)if(b==0)else(a//b))
def tm(a,b):
    return ((0)if(b==0)else(a%b))
s=[]
def sp():
    global s
    if (len(s) == 0):
        return 0
    return s.pop()
def sa(v):
    global s
    s.append(v)
def sr():
    global s
    if (len(s) == 0):
        return 0
    return s[-1]
def _0():
    gw(7,0,1)
    gw(1,0,80)
    gw(2,0,3)
    gw(4,0,240)
    gw(3,0,2)
    return 1
def _1():
    gw(0,1,32)
    gw(1,1,32)
    gw(8,0,1073741824)
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+1,88)
    sa(gr(3,0)+gr(3,0))
    sa((1)if((gr(3,0)+gr(3,0))<gr(4,0))else(0))
    return 2
def _2():
    return (15)if(sp()!=0)else(3)
def _3():
    sp();
    return 4
def _4():
    global t0
    sa(gr(3,0)+1)
    gw(3,0,gr(3,0)+1)
    sa(tm(sr(),gr(1,0)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(1,0)))

    sa(sp()+1);

    v0=sp()
    t0=gr(sp(),v0)
    t0=t0-32
    return 5
def _5():
    global t0
    return (6)if((t0)!=0)else(4)
def _6():
    return (1)if(gr(4,0)>gr(3,0))else(7)
def _7():
    gw(3,0,0)
    gw(5,0,0)
    return 8
def _8():
    return (14)if(gr(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+1)!=32)else(9)
def _9():
    global t0
    t0=gr(3,0)+1
    gw(3,0,gr(3,0)+1)
    t0=t0-gr(4,0)

    return (8)if((t0)!=0)else(10)
def _10():
    gw(6,0,1000000)
    sa(0)
    sa(gr(0,1)*gr(7,0))
    sa((1)if((gr(0,1)*gr(7,0))>gr(6,0))else(0))
    return 11
def _11():
    return (13)if(sp()!=0)else(12)
def _12():
    gw(7,0,sp())
    sa(sp()+1);

    sa(sr());
    sa(1)
    v0=sp()
    sa(gr(sp(),v0))
    sa(sp()*gr(7,0));

    sa((1)if(sr()>gr(6,0))else(0))
    return 11
def _13():
    print(gr(7,0),end=" ",flush=True)
    sp();
    sp();
    return 16
def _14():
    gw(gr(5,0),1,gr(3,0))
    gw(5,0,gr(5,0)+1)
    return 9
def _15():
    sa(sr());
    sa(32)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(tm(sr(),gr(1,0)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(1,0)))

    sa(sp()+1);

    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()+gr(3,0));

    sa((1)if(sr()<gr(4,0))else(0))
    return 2
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15]
c=0
while c<16:
    c=m[c]()
