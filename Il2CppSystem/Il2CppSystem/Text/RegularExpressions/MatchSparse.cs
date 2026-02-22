using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000059 RID: 89
	public class MatchSparse : Match
	{
		// Token: 0x06000636 RID: 1590 RVA: 0x000278F0 File Offset: 0x00025AF0
		// Note: this type is marked as 'beforefieldinit'.
		static MatchSparse()
		{
			Il2CppClassPointerStore<MatchSparse>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "MatchSparse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchSparse>.NativeClassPtr);
			MatchSparse.NativeFieldInfoPtr__caps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchSparse>.NativeClassPtr, "_caps");
			MatchSparse.NativeMethodInfoPtr__ctor_Internal_Void_Regex_Hashtable_Int32_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchSparse>.NativeClassPtr, 100664117);
			MatchSparse.NativeMethodInfoPtr_get_Groups_Public_Virtual_get_GroupCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchSparse>.NativeClassPtr, 100664118);
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x0002795C File Offset: 0x00025B5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39622, RefRangeEnd = 39623, XrefRangeStart = 39618, XrefRangeEnd = 39622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchSparse(Regex regex, Hashtable caps, int capcount, string text, int begpos, int len, int startpos)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchSparse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(regex);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(caps);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capcount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref begpos;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startpos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchSparse.NativeMethodInfoPtr__ctor_Internal_Void_Regex_Hashtable_Int32_String_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000638 RID: 1592 RVA: 0x00027A04 File Offset: 0x00025C04
		public unsafe override GroupCollection Groups
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39623, XrefRangeEnd = 39627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MatchSparse.NativeMethodInfoPtr_get_Groups_Public_Virtual_get_GroupCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GroupCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00004678 File Offset: 0x00002878
		public MatchSparse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x0600063A RID: 1594 RVA: 0x00027A50 File Offset: 0x00025C50
		// (set) Token: 0x0600063B RID: 1595 RVA: 0x00004681 File Offset: 0x00002881
		public new unsafe Hashtable _caps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchSparse.NativeFieldInfoPtr__caps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchSparse.NativeFieldInfoPtr__caps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000497 RID: 1175
		private static readonly IntPtr NativeFieldInfoPtr__caps;

		// Token: 0x04000498 RID: 1176
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Regex_Hashtable_Int32_String_Int32_Int32_Int32_0;

		// Token: 0x04000499 RID: 1177
		private static readonly IntPtr NativeMethodInfoPtr_get_Groups_Public_Virtual_get_GroupCollection_0;
	}
}
