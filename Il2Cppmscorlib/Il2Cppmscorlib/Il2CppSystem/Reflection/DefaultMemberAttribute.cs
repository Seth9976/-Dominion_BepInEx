using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x0200019F RID: 415
	[Serializable]
	public sealed class DefaultMemberAttribute : Attribute
	{
		// Token: 0x06001BA5 RID: 7077 RVA: 0x0009E6C8 File Offset: 0x0009C8C8
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultMemberAttribute()
		{
			Il2CppClassPointerStore<DefaultMemberAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "DefaultMemberAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultMemberAttribute>.NativeClassPtr);
			DefaultMemberAttribute.NativeFieldInfoPtr_m_memberName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultMemberAttribute>.NativeClassPtr, "m_memberName");
			DefaultMemberAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultMemberAttribute>.NativeClassPtr, 100667918);
			DefaultMemberAttribute.NativeMethodInfoPtr_get_MemberName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultMemberAttribute>.NativeClassPtr, 100667919);
		}

		// Token: 0x06001BA6 RID: 7078 RVA: 0x0009E734 File Offset: 0x0009C934
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 14927, RefRangeEnd = 14932, XrefRangeStart = 14927, XrefRangeEnd = 14932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultMemberAttribute(string memberName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultMemberAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(memberName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultMemberAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06001BA7 RID: 7079 RVA: 0x0009E780 File Offset: 0x0009C980
		public unsafe string MemberName
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultMemberAttribute.NativeMethodInfoPtr_get_MemberName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001BA8 RID: 7080 RVA: 0x000098AC File Offset: 0x00007AAC
		public DefaultMemberAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06001BA9 RID: 7081 RVA: 0x0009E7B8 File Offset: 0x0009C9B8
		// (set) Token: 0x06001BAA RID: 7082 RVA: 0x000098B5 File Offset: 0x00007AB5
		public unsafe string m_memberName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultMemberAttribute.NativeFieldInfoPtr_m_memberName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultMemberAttribute.NativeFieldInfoPtr_m_memberName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400190B RID: 6411
		private static readonly IntPtr NativeFieldInfoPtr_m_memberName;

		// Token: 0x0400190C RID: 6412
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400190D RID: 6413
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberName_Public_get_String_0;
	}
}
