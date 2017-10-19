#!/usr/bin/env python2

# transpiled with BefunCompile v1.3.0 (c) 2017
import sys
import zlib, base64
_g = ("AR+LCAAAAAAABAClUUFqxDAQ+4pJ9zQmRRpvdjfBmD6khB4Kc52TT3l8nW4CbSGFbnWwPTPIkuX6tCP8HY+x/o2CHYQrPMHP8AF+gV/hN/gID6F771RCIH1UOhI9oNaH"
  + "VU/5W1kdTp0ijYo2KqaDSLzCBok3mEocYXHXK0qDMa6br8XYb5OlsHGaWRFttM9DbGuqZSLt9W3x4yTmMF+iyHkwDFE67QznKIZcN7cztWc+vOD+lG2+e81Lb2S4d5df"
  + "iD2nvBimFkF2pjWL9FWrnBLt+eXYPvv2M2H+0f4AZyRUOpQCAAA=")
g = base64.b64decode(_g)[1:]
for i in range(ord(base64.b64decode(_g)[0])):
    g = zlib.decompress(g, 16+zlib.MAX_WBITS)
g=list(map(ord, g))
def gr(x,y):
    if(x>=0 and y>=0 and x<60 and y<11):
        return g[y*60 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<60 and y<11):
        g[y*60 + x]=v;
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
    gw(1,0,0)
    gw(2,0,0)
    gw(3,0,0)
    gw(4,0,0)
    gw(5,0,0)
    gw(6,0,0)
    gw(7,0,0)
    gw(8,0,0)
    gw(9,0,0)
    gw(1,1,200)
    gw(2,1,9)
    gw(3,1,0)
    sa(0)
    return 1
def _1():
    sp();
    return 2
def _2():
    gw(gr(2,1),0,gr(gr(2,1),0)+1)
    return 3
def _3():
    return (12)if(gr(2,1)!=9)else(4)
def _4():
    sa((gr(1,0)*500)+(gr(2,0)*200)+(100*gr(3,0))+(gr(4,0)*50)+(gr(5,0)*20)+(gr(6,0)*10)+(gr(7,0)*5)+(gr(8,0)*2)+gr(9,0))

    return (1)if(((gr(1,0)*500)+(gr(2,0)*200)+(100*gr(3,0))+(gr(4,0)*50)+(gr(5,0)*20)+(gr(6,0)*10)+(gr(7,0)*5)+(gr(8,0)*2)+gr(9,0))<gr(1,1))else(5)
def _5():
    sa(sp()-gr(1,1))


    return (6)if(sp()!=0)else(11)
def _6():
    global t0
    t0=gr(2,1)

    return (8)if((gr(gr(2,1),0))!=0)else(7)
def _7():
    global t0
    t0=t0-1
    gw(2,1,t0)
    return 6
def _8():
    global t0
    return (10)if(t0!=1)else(9)
def _9():
    sys.stdout.write(str(gr(3,1))+" ")
    sys.stdout.flush()
    return 13
def _10():
    global t0
    t0=t0-1
    gw(2,1,t0)
    return 2
def _11():
    gw(3,1,gr(3,1)+1)
    return 6
def _12():
    sa(0)
    sa(gr(2,1)+1)
    gw(2,1,gr(2,1)+1)
    sa(0)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    return 3
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12]
c=0
while c<13:
    c=m[c]()
