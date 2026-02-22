using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UTNotifications
{
	// Token: 0x020000ED RID: 237
	public class Button : Object
	{
		// Token: 0x06001CC0 RID: 7360 RVA: 0x000704D8 File Offset: 0x0006E6D8
		// Note: this type is marked as 'beforefieldinit'.
		static Button()
		{
			Il2CppClassPointerStore<Button>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UTNotifications", "Button");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Button>.NativeClassPtr);
			Button.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Button>.NativeClassPtr, "title");
			Button.NativeFieldInfoPtr_userData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Button>.NativeClassPtr, "userData");
			Button.NativeMethodInfoPtr__ctor_Public_Void_String_IDictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Button>.NativeClassPtr, 100665568);
		}

		// Token: 0x06001CC1 RID: 7361 RVA: 0x00070544 File Offset: 0x0006E744
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 5356, RefRangeEnd = 5400, XrefRangeStart = 5356, XrefRangeEnd = 5400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Button(string title, IDictionary<string, string> userData = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Button>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(userData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Button.NativeMethodInfoPtr__ctor_Public_Void_String_IDictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CC2 RID: 7362 RVA: 0x0001263F File Offset: 0x0001083F
		public Button(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06001CC3 RID: 7363 RVA: 0x000705A4 File Offset: 0x0006E7A4
		// (set) Token: 0x06001CC4 RID: 7364 RVA: 0x00012648 File Offset: 0x00010848
		public unsafe string title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Button.NativeFieldInfoPtr_title);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Button.NativeFieldInfoPtr_title), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06001CC5 RID: 7365 RVA: 0x000705CC File Offset: 0x0006E7CC
		// (set) Token: 0x06001CC6 RID: 7366 RVA: 0x00012667 File Offset: 0x00010867
		public unsafe IDictionary<string, string> userData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Button.NativeFieldInfoPtr_userData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Button.NativeFieldInfoPtr_userData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400135D RID: 4957
		private static readonly IntPtr NativeFieldInfoPtr_title;

		// Token: 0x0400135E RID: 4958
		private static readonly IntPtr NativeFieldInfoPtr_userData;

		// Token: 0x0400135F RID: 4959
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_IDictionary_2_String_String_0;
	}
}
