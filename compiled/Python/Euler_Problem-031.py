# compiled with BefunCompile v1.0.4 (c) 2015
# execute with at least Python3
import gzip, base64
_g = ("AR+LCAAAAAAABAClUUFqxDAQ+4pJ9zQmRRpvdjfBmD6khB4Kc52TT3l8nW4CbSGFbnWwPTPIkuX6tCP8HY+x/o2CHYQrPMHP8AF+gV/hN/gID6F771RCIH1UOhI9oNaH"
  + "VU/5W1kdTp0ijYo2KqaDSLzCBok3mEocYXHXK0qDMa6br8XYb5OlsHGaWRFttM9DbGuqZSLt9W3x4yTmMF+iyHkwDFE67QznKIZcN7cztWc+vOD+lG2+e81Lb2S4d5df"
  + "iD2nvBimFkF2pjWL9FWrnBLt+eXYPvv2M2H+0f4AZyRUOpQCAAA=")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<60 and y<11):
        return g[y*60 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<60 and y<11):
        g[y*60 + x]=v;
def td(a,b):
    return bool(random.getrandbits(1))
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
    gw(gr(2,1),0,(gr(gr(2,1),0))+(1))
    return 1
def _1():
    return (11)if((gr(2,1))-(9))else(2)
def _2():
    sa((((((((((gr(1,0))*(500))+((gr(2,0))*(200)))+((100)*(gr(3,0))))+((gr(4,0))*(50)))+((gr(5,0))*(20)))+((gr(6,0))*(10)))+((gr(7,0))*(5)))+((gr(8,0))*(2)))+(gr(9,0)))
    return (10)if((1)if((gr(1,1))>((((((((((gr(1,0))*(500))+((gr(2,0))*(200)))+((100)*(gr(3,0))))+((gr(4,0))*(50)))+((gr(5,0))*(20)))+((gr(6,0))*(10)))+((gr(7,0))*(5)))+((gr(8,0))*(2)))+(gr(9,0))))else(0))else(3)
def _3():
    sa(gr(1,1))
    v0=sp()
    sa(sp()-v0)
    return (4)if(sp()!=0)else(9)
def _4():
    sa(gr(2,1))
    return (5)if(gr(gr(2,1),0))else(8)
def _5():
    sa(sr())
    sa(1)
    v0=sp()
    sa(sp()-v0)
    return (6)if(sp()!=0)else(7)
def _6():
    sa(1)
    v0=sp()
    sa(sp()-v0)
    gw(2,1,sp())
    gw(gr(2,1),0,(gr(gr(2,1),0))+(1))
    return 1
def _7():
    sp()
    print(gr(3,1),end="",flush=True)
    return 12
def _8():
    sa(1)
    v0=sp()
    sa(sp()-v0)
    gw(2,1,sp())
    return 4
def _9():
    gw(3,1,(gr(3,1))+(1))
    return 4
def _10():
    gw(gr(2,1),0,(gr(gr(2,1),0))+(1))
    sp()
    return 1
def _11():
    sa(0)
    sa((gr(2,1))+(1))
    gw(2,1,(gr(2,1))+(1))
    sa(0)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    return 1
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11]
c=0
while c<12:
    c=m[c]()