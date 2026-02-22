using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000043 RID: 67
	[StructLayout(2)]
	public struct Ray
	{
		// Token: 0x06000427 RID: 1063 RVA: 0x0001FF88 File Offset: 0x0001E188
		// Note: this type is marked as 'beforefieldinit'.
		static Ray()
		{
			Il2CppClassPointerStore<Ray>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Ray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Ray>.NativeClassPtr);
			Ray.NativeFieldInfoPtr_m_Origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ray>.NativeClassPtr, "m_Origin");
			Ray.NativeFieldInfoPtr_m_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ray>.NativeClassPtr, "m_Direction");
			Ray.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray>.NativeClassPtr, 100663505);
			Ray.NativeMethodInfoPtr_get_origin_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray>.NativeClassPtr, 100663506);
			Ray.NativeMethodInfoPtr_get_direction_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray>.NativeClassPtr, 100663507);
			Ray.NativeMethodInfoPtr_GetPoint_Public_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray>.NativeClassPtr, 100663508);
			Ray.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray>.NativeClassPtr, 100663509);
			Ray.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray>.NativeClassPtr, 100663510);
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00020058 File Offset: 0x0001E258
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 61413, RefRangeEnd = 61443, XrefRangeStart = 61412, XrefRangeEnd = 61413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ray(Vector3 origin, Vector3 direction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ray.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x00020098 File Offset: 0x0001E298
		// (set) Token: 0x0600042F RID: 1071 RVA: 0x00004975 File Offset: 0x00002B75
		public unsafe Vector3 origin
		{
			[CallerCount(36)]
			[CachedScanResults(RefRangeStart = 61063, RefRangeEnd = 61099, XrefRangeStart = 61063, XrefRangeEnd = 61099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ray.NativeMethodInfoPtr_get_origin_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Origin = value;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x000200C8 File Offset: 0x0001E2C8
		// (set) Token: 0x06000430 RID: 1072 RVA: 0x0000497F File Offset: 0x00002B7F
		public unsafe Vector3 direction
		{
			[CallerCount(64)]
			[CachedScanResults(RefRangeStart = 61152, RefRangeEnd = 61216, XrefRangeStart = 61152, XrefRangeEnd = 61216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ray.NativeMethodInfoPtr_get_direction_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Direction = value.normalized;
			}
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x000200F8 File Offset: 0x0001E2F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 61443, RefRangeEnd = 61446, XrefRangeStart = 61443, XrefRangeEnd = 61443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPoint(float distance)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref distance;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ray.NativeMethodInfoPtr_GetPoint_Public_Vector3_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00020138 File Offset: 0x0001E338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61446, XrefRangeEnd = 61447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ray.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00020164 File Offset: 0x0001E364
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 61473, RefRangeEnd = 61474, XrefRangeStart = 61447, XrefRangeEnd = 61473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ray.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00004963 File Offset: 0x00002B63
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Ray>.NativeClassPtr, ref this));
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x000201B4 File Offset: 0x0001E3B4
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x040002D9 RID: 729
		private static readonly IntPtr NativeFieldInfoPtr_m_Origin;

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeFieldInfoPtr_m_Direction;

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeMethodInfoPtr_get_origin_Public_get_Vector3_0;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeMethodInfoPtr_get_direction_Public_get_Vector3_0;

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeMethodInfoPtr_GetPoint_Public_Vector3_Single_0;

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x040002E1 RID: 737
		[FieldOffset(0)]
		public Vector3 m_Origin;

		// Token: 0x040002E2 RID: 738
		[FieldOffset(12)]
		public Vector3 m_Direction;
	}
}
