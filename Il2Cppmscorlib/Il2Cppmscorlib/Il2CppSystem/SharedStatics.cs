using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security.Util;

namespace Il2CppSystem
{
	// Token: 0x020000E4 RID: 228
	public sealed class SharedStatics : Object
	{
		// Token: 0x06000F65 RID: 3941 RVA: 0x00068B08 File Offset: 0x00066D08
		// Note: this type is marked as 'beforefieldinit'.
		static SharedStatics()
		{
			Il2CppClassPointerStore<SharedStatics>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "SharedStatics");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedStatics>.NativeClassPtr);
			SharedStatics.NativeFieldInfoPtr__sharedStatics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedStatics>.NativeClassPtr, "_sharedStatics");
			SharedStatics.NativeFieldInfoPtr__maker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedStatics>.NativeClassPtr, "_maker");
			SharedStatics.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedStatics>.NativeClassPtr, 100665912);
			SharedStatics.NativeMethodInfoPtr_GetSharedStringMaker_Public_Static_StringMaker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedStatics>.NativeClassPtr, 100665913);
			SharedStatics.NativeMethodInfoPtr_ReleaseSharedStringMaker_Public_Static_Void_byref_StringMaker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedStatics>.NativeClassPtr, 100665914);
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x00068B9C File Offset: 0x00066D9C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SharedStatics()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedStatics>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedStatics.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x00068BD8 File Offset: 0x00066DD8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 291954, RefRangeEnd = 291957, XrefRangeStart = 291935, XrefRangeEnd = 291954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tokenizer.StringMaker GetSharedStringMaker()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedStatics.NativeMethodInfoPtr_GetSharedStringMaker_Public_Static_StringMaker_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tokenizer.StringMaker>(intPtr3) : null;
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x00068C0C File Offset: 0x00066E0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 291969, RefRangeEnd = 291971, XrefRangeStart = 291957, XrefRangeEnd = 291969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseSharedStringMaker(ref Tokenizer.StringMaker maker)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(maker);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SharedStatics.NativeMethodInfoPtr_ReleaseSharedStringMaker_Public_Static_Void_byref_StringMaker_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				maker = ((intPtr4 == 0) ? null : new Tokenizer.StringMaker(intPtr4));
			}
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x00005E3F File Offset: 0x0000403F
		public SharedStatics(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000F6A RID: 3946 RVA: 0x00068C58 File Offset: 0x00066E58
		// (set) Token: 0x06000F6B RID: 3947 RVA: 0x00005E48 File Offset: 0x00004048
		public unsafe static SharedStatics _sharedStatics
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SharedStatics.NativeFieldInfoPtr__sharedStatics, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SharedStatics>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SharedStatics.NativeFieldInfoPtr__sharedStatics, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000F6C RID: 3948 RVA: 0x00068C80 File Offset: 0x00066E80
		// (set) Token: 0x06000F6D RID: 3949 RVA: 0x00005E5A File Offset: 0x0000405A
		public unsafe Tokenizer.StringMaker _maker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedStatics.NativeFieldInfoPtr__maker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tokenizer.StringMaker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedStatics.NativeFieldInfoPtr__maker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D14 RID: 3348
		private static readonly IntPtr NativeFieldInfoPtr__sharedStatics;

		// Token: 0x04000D15 RID: 3349
		private static readonly IntPtr NativeFieldInfoPtr__maker;

		// Token: 0x04000D16 RID: 3350
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000D17 RID: 3351
		private static readonly IntPtr NativeMethodInfoPtr_GetSharedStringMaker_Public_Static_StringMaker_0;

		// Token: 0x04000D18 RID: 3352
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseSharedStringMaker_Public_Static_Void_byref_StringMaker_0;
	}
}
