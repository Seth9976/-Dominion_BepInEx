using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000B9 RID: 185
	[StructLayout(2)]
	public struct RangeInt
	{
		// Token: 0x060010E3 RID: 4323 RVA: 0x00045018 File Offset: 0x00043218
		// Note: this type is marked as 'beforefieldinit'.
		static RangeInt()
		{
			Il2CppClassPointerStore<RangeInt>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RangeInt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RangeInt>.NativeClassPtr);
			RangeInt.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeInt>.NativeClassPtr, "start");
			RangeInt.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeInt>.NativeClassPtr, "length");
			RangeInt.NativeMethodInfoPtr_get_end_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeInt>.NativeClassPtr, 100664448);
			RangeInt.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeInt>.NativeClassPtr, 100664449);
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x060010E4 RID: 4324 RVA: 0x00045098 File Offset: 0x00043298
		public unsafe int end
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 72355, RefRangeEnd = 72357, XrefRangeStart = 72355, XrefRangeEnd = 72355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RangeInt.NativeMethodInfoPtr_get_end_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010E5 RID: 4325 RVA: 0x000450C8 File Offset: 0x000432C8
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 16465, RefRangeEnd = 16495, XrefRangeStart = 16465, XrefRangeEnd = 16495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RangeInt(int start, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RangeInt.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010E6 RID: 4326 RVA: 0x0000A44B File Offset: 0x0000864B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RangeInt>.NativeClassPtr, ref this));
		}

		// Token: 0x04000CB8 RID: 3256
		private static readonly IntPtr NativeFieldInfoPtr_start;

		// Token: 0x04000CB9 RID: 3257
		private static readonly IntPtr NativeFieldInfoPtr_length;

		// Token: 0x04000CBA RID: 3258
		private static readonly IntPtr NativeMethodInfoPtr_get_end_Public_get_Int32_0;

		// Token: 0x04000CBB RID: 3259
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x04000CBC RID: 3260
		[FieldOffset(0)]
		public int start;

		// Token: 0x04000CBD RID: 3261
		[FieldOffset(4)]
		public int length;
	}
}
