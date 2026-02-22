using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace TMPro
{
	// Token: 0x0200001A RID: 26
	[Serializable]
	[StructLayout(2)]
	public struct Mesh_Extents
	{
		// Token: 0x06000263 RID: 611 RVA: 0x000122E8 File Offset: 0x000104E8
		// Note: this type is marked as 'beforefieldinit'.
		static Mesh_Extents()
		{
			Il2CppClassPointerStore<Mesh_Extents>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "Mesh_Extents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Mesh_Extents>.NativeClassPtr);
			Mesh_Extents.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mesh_Extents>.NativeClassPtr, "min");
			Mesh_Extents.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mesh_Extents>.NativeClassPtr, "max");
			Mesh_Extents.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh_Extents>.NativeClassPtr, 100663567);
			Mesh_Extents.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh_Extents>.NativeClassPtr, 100663568);
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00012368 File Offset: 0x00010568
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 52612, RefRangeEnd = 52647, XrefRangeStart = 52612, XrefRangeEnd = 52647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Mesh_Extents(Vector2 min, Vector2 max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh_Extents.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x000123A8 File Offset: 0x000105A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137515, XrefRangeEnd = 137588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh_Extents.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00002F06 File Offset: 0x00001106
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Mesh_Extents>.NativeClassPtr, ref this));
		}

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeFieldInfoPtr_min;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeFieldInfoPtr_max;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_0;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040001D5 RID: 469
		[FieldOffset(0)]
		public Vector2 min;

		// Token: 0x040001D6 RID: 470
		[FieldOffset(8)]
		public Vector2 max;
	}
}
