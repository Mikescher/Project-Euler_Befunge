# compiled with BefunCompile v1.0.5 (c) 2015
# execute with at least Python3
import gzip, base64
_g = ("AR+LCAAAAAAABADt2r1qwzAQwPFXcf2xWP44OdIQEUQfJDQdClo1acrD54JLoLSQ0jY0tP/fcqeTrEFGN6lUuCcNAAAAAAAAAAAAAAAAAAB/wLX3cuU1xsvKcs52t3qf"
  + "99/F+qV2fbCSve97kSySoh1DWDTdL3PUJO275ukQNpLNZp3VYVuub44fcQwfFLOxcxKbZOnWwBW5hdK2b8bZinDSvydqf7LjuTltJUftTVZSt4bZmuQku7XmLjUvudIV"
  + "XtLYlINmOvX8sKZTXY1VPQyD1ibvzUBX+4ZjlmW0QZvRZ7/YvU/1zxqTxOkuSbbcta95nDi8e3ACPGJLlpAzAAA=")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<400 and y<33):
        return g[y*400 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<400 and y<33):
        g[y*400 + x]=v;
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
    gw(1,0,400)
    gw(0,0,10000)
    sa(gr(0,0)-1)
    sa(gr(0,0)-1)
    gw(2,0,gr(0,0)-1)
    return 1
def _1():
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(2)
    v0=sp()
    sa(td(sp(),v0))
    return 2
def _2():
    sa(sr())
    sa(gr(2,0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(tm(sp(),v0))
    return (14)if(sp()!=0)else(3)
def _3():
    sa(sr())
    gw(3,0,sp())
    sa(sp()+sp());
    sa(gr(3,0)-1)
    sa(gr(3,0)-1)
    return 4
def _4():
    return (2)if(sp()!=0)else(5)
def _5():
    sp()
    gw(tm(gr(2,0),gr(1,0)),(td(gr(2,0),gr(1,0)))+1,sp())
    sa(sr())
    return (6)if(sp()!=0)else(7)
def _6():
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    sa(sr())
    gw(2,0,sp())
    return 1
def _7():
    gw(0,1,0)
    gw(2,0,gr(0,0)-1)
    gw(9,0,0)
    gw(4,0,gr(tm(gr(2,0),gr(1,0)),(td(gr(2,0),gr(1,0)))+1))
    gw(5,0,gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+1))
    sp()
    sp()
    return 8
def _8():
    return (10)if(gr(2,0)-gr(5,0))else(9)
def _9():
    sa((0)if(((1)if((gr(2,0))>(gr(4,0)))else(0))!=0)else(1))
    return (10)if(sp()!=0)else(13)
def _10():
    sa(gr(2,0))
    gw(2,0,gr(2,0)-1)
    return (11)if(sp()!=0)else(12)
def _11():
    gw(4,0,gr(tm(gr(2,0),gr(1,0)),(td(gr(2,0),gr(1,0)))+1))
    gw(5,0,gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+1))
    return 8
def _12():
    print(gr(9,0),end="",flush=True)
    return 15
def _13():
    print(gr(2,0),end="",flush=True)
    sa(32)
    sa(45)
    print(chr(32),end="",flush=True)
    print(chr(sp()),end="",flush=True)
    print(chr(sp()),end="",flush=True)
    print(gr(4,0),end="",flush=True)
    print(chr(10),end="",flush=True)
    gw(9,0,gr(9,0)+gr(2,0)+gr(4,0))
    return 10
def _14():
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    return 4
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14]
c=0
while c<15:
    c=m[c]()