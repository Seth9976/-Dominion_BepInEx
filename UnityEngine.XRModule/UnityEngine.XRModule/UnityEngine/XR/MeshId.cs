using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.XR
{
	// Token: 0x02000014 RID: 20
	[StructLayout(2)]
	public struct MeshId
	{
		// Token: 0x06000120 RID: 288 RVA: 0x00005004 File Offset: 0x00003204
		// Note: this type is marked as 'beforefieldinit'.
		static MeshId()
		{
			Il2CppClassPointerStore<MeshId>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "MeshId");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshId>.NativeClassPtr);
			MeshId.NativeFieldInfoPtr_s_InvalidId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshId>.NativeClassPtr, "s_InvalidId");
			MeshId.NativeFieldInfoPtr_m_SubId1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshId>.NativeClassPtr, "m_SubId1");
			MeshId.NativeFieldInfoPtr_m_SubId2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshId>.NativeClassPtr, "m_SubId2");
			MeshId.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshId>.NativeClassPtr, 100663337);
			MeshId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshId>.NativeClassPtr, 100663338);
			MeshId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshId>.NativeClassPtr, 100663339);
			MeshId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MeshId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshId>.NativeClassPtr, 100663340);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000050C0 File Offset: 0x000032C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158349, XrefRangeEnd = 158359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshId.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000050EC File Offset: 0x000032EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158359, XrefRangeEnd = 158361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000511C File Offset: 0x0000331C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158361, XrefRangeEnd = 158364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00005160 File Offset: 0x00003360
		[CallerCount(0)]
		public unsafe bool Equals(MeshId other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MeshId_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00002B26 File Offset: 0x00000D26
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MeshId>.NativeClassPtr, ref this));
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000126 RID: 294 RVA: 0x000051A0 File Offset: 0x000033A0
		// (set) Token: 0x06000127 RID: 295 RVA: 0x00002B38 File Offset: 0x00000D38
		public unsafe static MeshId s_InvalidId
		{
			get
			{
				MeshId meshId;
				IL2CPP.il2cpp_field_static_get_value(MeshId.NativeFieldInfoPtr_s_InvalidId, (void*)(&meshId));
				return meshId;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MeshId.NativeFieldInfoPtr_s_InvalidId, (void*)(&value));
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x000051BC File Offset: 0x000033BC
		public static bool operator ==(MeshId id1, MeshId id2)
		{
			return id1.m_SubId1 == id2.m_SubId1 && id1.m_SubId2 == id2.m_SubId2;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000051F0 File Offset: 0x000033F0
		public static bool operator !=(MeshId id1, MeshId id2)
		{
			return id1.m_SubId1 != id2.m_SubId1 || id1.m_SubId2 != id2.m_SubId2;
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00005224 File Offset: 0x00003424
		public static MeshId InvalidId
		{
			get
			{
				return MeshId.s_InvalidId;
			}
		}

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeFieldInfoPtr_s_InvalidId;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeFieldInfoPtr_m_SubId1;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeFieldInfoPtr_m_SubId2;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MeshId_0;

		// Token: 0x040000DD RID: 221
		[FieldOffset(0)]
		public ulong m_SubId1;

		// Token: 0x040000DE RID: 222
		[FieldOffset(8)]
		public ulong m_SubId2;
	}
}
