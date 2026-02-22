using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Globalization.Unicode
{
	// Token: 0x02000018 RID: 24
	public class Level2Map : Object
	{
		// Token: 0x060000CC RID: 204 RVA: 0x0002551C File Offset: 0x0002371C
		// Note: this type is marked as 'beforefieldinit'.
		static Level2Map()
		{
			Il2CppClassPointerStore<Level2Map>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Globalization.Unicode", "Level2Map");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Level2Map>.NativeClassPtr);
			Level2Map.NativeFieldInfoPtr_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level2Map>.NativeClassPtr, "Source");
			Level2Map.NativeFieldInfoPtr_Replace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level2Map>.NativeClassPtr, "Replace");
			Level2Map.NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Level2Map>.NativeClassPtr, 100663418);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00025588 File Offset: 0x00023788
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 258832, RefRangeEnd = 258833, XrefRangeStart = 258831, XrefRangeEnd = 258832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Level2Map(byte source, byte replace)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Level2Map>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref replace;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Level2Map.NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000253A File Offset: 0x0000073A
		public Level2Map(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000CF RID: 207 RVA: 0x000255E0 File Offset: 0x000237E0
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x00002543 File Offset: 0x00000743
		public unsafe byte Source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level2Map.NativeFieldInfoPtr_Source);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level2Map.NativeFieldInfoPtr_Source)) = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00025608 File Offset: 0x00023808
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x0000255E File Offset: 0x0000075E
		public unsafe byte Replace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level2Map.NativeFieldInfoPtr_Replace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level2Map.NativeFieldInfoPtr_Replace)) = value;
			}
		}

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeFieldInfoPtr_Source;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeFieldInfoPtr_Replace;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_0;
	}
}
