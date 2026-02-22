using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000042 RID: 66
	[StructLayout(2)]
	public struct Plane
	{
		// Token: 0x06000412 RID: 1042 RVA: 0x0001FC50 File Offset: 0x0001DE50
		// Note: this type is marked as 'beforefieldinit'.
		static Plane()
		{
			Il2CppClassPointerStore<Plane>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Plane");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Plane>.NativeClassPtr);
			Plane.NativeFieldInfoPtr_m_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plane>.NativeClassPtr, "m_Normal");
			Plane.NativeFieldInfoPtr_m_Distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plane>.NativeClassPtr, "m_Distance");
			Plane.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100663501);
			Plane.NativeMethodInfoPtr_Raycast_Public_Boolean_Ray_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100663502);
			Plane.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100663503);
			Plane.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100663504);
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x0001FCF8 File Offset: 0x0001DEF8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 61373, RefRangeEnd = 61376, XrefRangeStart = 61372, XrefRangeEnd = 61373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Plane(Vector3 inNormal, Vector3 inPoint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inNormal;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0001FD38 File Offset: 0x0001DF38
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 61381, RefRangeEnd = 61384, XrefRangeStart = 61376, XrefRangeEnd = 61381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Raycast(Ray ray, out float enter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ray;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &enter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_Raycast_Public_Boolean_Ray_byref_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0001FD84 File Offset: 0x0001DF84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61384, XrefRangeEnd = 61385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x0001FDB0 File Offset: 0x0001DFB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 61411, RefRangeEnd = 61412, XrefRangeStart = 61385, XrefRangeEnd = 61411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider formatProvider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x000048AF File Offset: 0x00002AAF
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Plane>.NativeClassPtr, ref this));
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x0001FE00 File Offset: 0x0001E000
		// (set) Token: 0x06000419 RID: 1049 RVA: 0x000048C1 File Offset: 0x00002AC1
		public Vector3 normal
		{
			get
			{
				return this.m_Normal;
			}
			set
			{
				this.m_Normal = value;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x0001FE18 File Offset: 0x0001E018
		// (set) Token: 0x0600041B RID: 1051 RVA: 0x000048CB File Offset: 0x00002ACB
		public float distance
		{
			get
			{
				return this.m_Distance;
			}
			set
			{
				this.m_Distance = value;
			}
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x000048D5 File Offset: 0x00002AD5
		public void SetNormalAndPosition(Vector3 inNormal, Vector3 inPoint)
		{
			this.m_Normal = Vector3.Normalize(inNormal);
			this.m_Distance = -Vector3.Dot(inNormal, inPoint);
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x000048F2 File Offset: 0x00002AF2
		public void Set3Points(Vector3 a, Vector3 b, Vector3 c)
		{
			this.m_Normal = Vector3.Normalize(Vector3.Cross(b - a, c - a));
			this.m_Distance = -Vector3.Dot(this.m_Normal, a);
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00004926 File Offset: 0x00002B26
		public void Flip()
		{
			this.m_Normal = -this.m_Normal;
			this.m_Distance = -this.m_Distance;
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600041F RID: 1055 RVA: 0x0001FE30 File Offset: 0x0001E030
		public Plane flipped
		{
			get
			{
				return new Plane(-this.m_Normal, -this.m_Distance);
			}
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00004947 File Offset: 0x00002B47
		public void Translate(Vector3 translation)
		{
			this.m_Distance += Vector3.Dot(this.m_Normal, translation);
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0001FE5C File Offset: 0x0001E05C
		public static Plane Translate(Plane plane, Vector3 translation)
		{
			return new Plane(plane.m_Normal, plane.m_Distance += Vector3.Dot(plane.m_Normal, translation));
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x0001FE94 File Offset: 0x0001E094
		public Vector3 ClosestPointOnPlane(Vector3 point)
		{
			float num = Vector3.Dot(this.m_Normal, point) + this.m_Distance;
			return point - this.m_Normal * num;
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x0001FECC File Offset: 0x0001E0CC
		public float GetDistanceToPoint(Vector3 point)
		{
			return Vector3.Dot(this.m_Normal, point) + this.m_Distance;
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0001FEF4 File Offset: 0x0001E0F4
		public bool GetSide(Vector3 point)
		{
			return Vector3.Dot(this.m_Normal, point) + this.m_Distance > 0f;
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0001FF20 File Offset: 0x0001E120
		public bool SameSide(Vector3 inPt0, Vector3 inPt1)
		{
			float distanceToPoint = this.GetDistanceToPoint(inPt0);
			float distanceToPoint2 = this.GetDistanceToPoint(inPt1);
			return (distanceToPoint > 0f && distanceToPoint2 > 0f) || (distanceToPoint <= 0f && distanceToPoint2 <= 0f);
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0001FF6C File Offset: 0x0001E16C
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x040002D0 RID: 720
		private static readonly IntPtr NativeFieldInfoPtr_m_Normal;

		// Token: 0x040002D1 RID: 721
		private static readonly IntPtr NativeFieldInfoPtr_m_Distance;

		// Token: 0x040002D2 RID: 722
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0;

		// Token: 0x040002D3 RID: 723
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Boolean_Ray_byref_Single_0;

		// Token: 0x040002D4 RID: 724
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040002D5 RID: 725
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x040002D6 RID: 726
		[FieldOffset(0)]
		public Vector3 m_Normal;

		// Token: 0x040002D7 RID: 727
		[FieldOffset(12)]
		public float m_Distance;

		// Token: 0x040002D8 RID: 728
		public const int size = 16;
	}
}
