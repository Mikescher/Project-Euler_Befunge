# compiled with BefunCompile v1.0.5 (c) 2015
# execute with at least Python3
import gzip, base64
_g = ("AR+LCAAAAAAABADtk01ug0AMha9CIWxs0dgj/mYUod6gF0CQ3SzrFascvm4SlAAJUdMsKoSl+dHT6I3ne9AF/7yi19bq90e/Nd9l+635LttvzXfZfmu+y/Zb812234ur"
  + "KgoowWDlqHbhZxgz1rpsDcpIKSdKYeCkqU838j0gu4QFoUy3erZGjnVxNTlBBGPLiQppdqXtxn1uAlY5l+Ns4LhmOcjk5vl6fHp883xVOUFBkjOUOhuwOqvCR4Vvdlfp"
  + "IH3PzdY6CL9CGwilJGxYmHVYMPn97ho91DbR3jMHLvFkILsArAJikh9WUHHinDMkgwzJG0Q/TPqkGWDyiC7LMHZR046f0syTabvICfEWs0wjN57sdeTa5u7yaiEbo7WY"
  + "6ymhst+XQkW/LzbXT59l+EQpQ3NiaEYMqwf82GcpTAj26hzDB/zGBPX/8DxleHbUj+RMiq1wT5BL4Z4gDwneq4rZG/b7t6hrU/KM+iE+S1Xr4M6bhC+3/+4XG7a30abe"
  + "P543GNU3DXw8oeAQAAA=")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<80 and y<54):
        return g[y*80 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<80 and y<54):
        g[y*80 + x]=v;
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
    gw(79,6,0)
    gw(79,12,0)
    gw(79,18,0)
    gw(79,24,0)
    gw(79,30,0)
    gw(79,36,0)
    sa(393)
    sa(394)
    return 1
def _1():
    return (2)if(sp()!=0)else(3)
def _2():
    sa(sr())
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa(79)
    v0=sp()
    sa(tm(sp(),v0))
    sa(1)
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(79)
    v0=sp()
    sa(td(sp(),v0))
    sa(2)
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr())
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa(79)
    v0=sp()
    sa(tm(sp(),v0))
    sa(1)
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(79)
    v0=sp()
    sa(td(sp(),v0))
    sa(8)
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr())
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa(79)
    v0=sp()
    sa(tm(sp(),v0))
    sa(1)
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(79)
    v0=sp()
    sa(td(sp(),v0))
    sa(14)
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr())
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa(79)
    v0=sp()
    sa(tm(sp(),v0))
    sa(1)
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(79)
    v0=sp()
    sa(td(sp(),v0))
    sa(20)
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr())
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa(79)
    v0=sp()
    sa(tm(sp(),v0))
    sa(1)
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(79)
    v0=sp()
    sa(td(sp(),v0))
    sa(26)
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr())
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa(79)
    v0=sp()
    sa(tm(sp(),v0))
    sa(1)
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(79)
    v0=sp()
    sa(td(sp(),v0))
    sa(32)
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    sa(1)
    sa(sp()+sp());
    return 1
def _3():
    gw(79,6,1)
    gw(79,12,1)
    gw(79,30,1)
    gw(7,0,0)
    gw(8,0,6)
    gw(9,0,12)
    gw(7,1,0)
    gw(8,1,6)
    gw(9,1,12)
    gw(1,1,1)
    gw(2,1,1)
    gw(4,0,0)
    gw(1,0,0)
    gw(2,0,394)
    sp()
    sa(999)
    return 4
def _4():
    sa(394)
    sa(gr(79,4+gr(7,0)+2)+(gr(79,4+gr(8,0)+2)*2)+gr(1,0))
    sa(tm(gr(79,4+gr(7,0)+2)+(gr(79,4+gr(8,0)+2)*2)+gr(1,0),10))
    sa(tm(gr(79,4+gr(7,0)+2)+(gr(79,4+gr(8,0)+2)*2)+gr(1,0),10))
    return 5
def _5():
    return (6)if(sp()!=0)else(8)
def _6():
    sa(395-gr(2,0))
    sa((1)if((395-gr(2,0))>(gr(1,1)))else(0))
    return (22)if(sp()!=0)else(7)
def _7():
    sp()
    return 8
def _8():
    gw((tm(gr(2,0),79))+1,(td(gr(2,0),79))+gr(9,0)+2,sp())
    sa(10)
    v0=sp()
    sa(td(sp(),v0))
    gw(1,0,sp())
    sa(sr())
    return (9)if(sp()!=0)else(10)
def _9():
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    sa(sr())
    sa(sr())
    gw(2,0,sp())
    sa(sr())
    sa(79)
    v0=sp()
    sa(tm(sp(),v0))
    sa(1)
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(79)
    v0=sp()
    sa(td(sp(),v0))
    sa(gr(7,0)+2)
    sa(sp()+sp());
    v0=sp()
    sa(gr(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa(79)
    v0=sp()
    sa(tm(sp(),v0))
    sa(1)
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(79)
    v0=sp()
    sa(td(sp(),v0))
    sa(gr(8,0)+2)
    sa(sp()+sp());
    v0=sp()
    sa(gr(sp(),v0))
    sa(2)
    sa(sp()*sp());
    sa(gr(1,0))
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sr())
    sa(10)
    v0=sp()
    sa(tm(sp(),v0))
    sa(sr())
    return 5
def _10():
    gw(7,0,tm(gr(7,0)+6,18))
    gw(8,0,tm(gr(8,0)+6,18))
    gw(9,0,tm(gr(9,0)+6,18))
    gw(1,0,0)
    gw(2,0,394)
    sp()
    sa(394)
    sa(gr(79,4+gr(7,1)+20)+(gr(79,4+gr(8,1)+20)*2)+gr(1,0))
    sa(tm(gr(79,4+gr(7,1)+20)+(gr(79,4+gr(8,1)+20)*2)+gr(1,0),10))
    sa(tm(gr(79,4+gr(7,1)+20)+(gr(79,4+gr(8,1)+20)*2)+gr(1,0),10))
    return 11
def _11():
    return (12)if(sp()!=0)else(14)
def _12():
    sa(395-gr(2,0))
    sa((1)if((395-gr(2,0))>(gr(2,1)))else(0))
    return (21)if(sp()!=0)else(13)
def _13():
    sp()
    return 14
def _14():
    gw((tm(gr(2,0),79))+1,(td(gr(2,0),79))+gr(9,1)+20,sp())
    sa(10)
    v0=sp()
    sa(td(sp(),v0))
    gw(1,0,sp())
    sa(sr())
    return (20)if(sp()!=0)else(15)
def _15():
    gw(7,1,tm(gr(7,1)+6,18))
    gw(8,1,tm(gr(8,1)+6,18))
    gw(9,1,tm(gr(9,1)+6,18))
    sp()
    sa((0)if(((1)if((gr(1,1))>(gr(2,1)))else(0))!=0)else(1))
    return (16)if(sp()!=0)else(19)
def _16():
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    return (18)if(sp()!=0)else(17)
def _17():
    sp()
    print(gr(4,0),end="",flush=True)
    return 23
def _18():
    gw(1,0,0)
    gw(2,0,394)
    return 4
def _19():
    gw(4,0,gr(4,0)+1)
    return 16
def _20():
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    sa(sr())
    sa(sr())
    gw(2,0,sp())
    sa(sr())
    sa(79)
    v0=sp()
    sa(tm(sp(),v0))
    sa(1)
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(79)
    v0=sp()
    sa(td(sp(),v0))
    sa(gr(7,1)+20)
    sa(sp()+sp());
    v0=sp()
    sa(gr(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa(79)
    v0=sp()
    sa(tm(sp(),v0))
    sa(1)
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(79)
    v0=sp()
    sa(td(sp(),v0))
    sa(gr(8,1)+20)
    sa(sp()+sp());
    v0=sp()
    sa(gr(sp(),v0))
    sa(2)
    sa(sp()*sp());
    sa(gr(1,0))
    sa(sp()+sp());
    sa(sp()+sp());
    sa(sr())
    sa(10)
    v0=sp()
    sa(tm(sp(),v0))
    sa(sr())
    return 11
def _21():
    gw(2,1,sp())
    return 14
def _22():
    gw(1,1,sp())
    return 8
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22]
c=0
while c<23:
    c=m[c]()