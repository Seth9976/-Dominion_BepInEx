using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200005B RID: 91
	public class MonoTODOAttribute : Attribute
	{
		// Token: 0x06000631 RID: 1585 RVA: 0x0003E4A4 File Offset: 0x0003C6A4
		// Note: this type is marked as 'beforefieldinit'.
		static MonoTODOAttribute()
		{
			Il2CppClassPointerStore<MonoTODOAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "MonoTODOAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoTODOAttribute>.NativeClassPtr);
			MonoTODOAttribute.NativeFieldInfoPtr_comment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTODOAttribute>.NativeClassPtr, "comment");
			MonoTODOAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTODOAttribute>.NativeClassPtr, 100664301);
			MonoTODOAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTODOAttribute>.NativeClassPtr, 100664302);
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x0003E510 File Offset: 0x0003C710
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoTODOAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoTODOAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTODOAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x0003E54C File Offset: 0x0003C74C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 14927, RefRangeEnd = 14932, XrefRangeStart = 14927, XrefRangeEnd = 14932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoTODOAttribute(string comment)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoTODOAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(comment);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTODOAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x00003F52 File Offset: 0x00002152
		public MonoTODOAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000635 RID: 1589 RVA: 0x0003E598 File Offset: 0x0003C798
		// (set) Token: 0x06000636 RID: 1590 RVA: 0x00003F5B File Offset: 0x0000215B
		public unsafe string comment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTODOAttribute.NativeFieldInfoPtr_comment);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTODOAttribute.NativeFieldInfoPtr_comment), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040004A0 RID: 1184
		private static readonly IntPtr NativeFieldInfoPtr_comment;

		// Token: 0x040004A1 RID: 1185
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040004A2 RID: 1186
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
