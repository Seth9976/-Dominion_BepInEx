using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Xml;

namespace SA.Manifest
{
	// Token: 0x02000322 RID: 802
	public class ApplicationTemplate : BaseTemplate
	{
		// Token: 0x06002F3D RID: 12093 RVA: 0x000C9C08 File Offset: 0x000C7E08
		// Note: this type is marked as 'beforefieldinit'.
		static ApplicationTemplate()
		{
			Il2CppClassPointerStore<ApplicationTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Manifest", "ApplicationTemplate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ApplicationTemplate>.NativeClassPtr);
			ApplicationTemplate.NativeFieldInfoPtr__activities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplicationTemplate>.NativeClassPtr, "_activities");
			ApplicationTemplate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationTemplate>.NativeClassPtr, 100669547);
			ApplicationTemplate.NativeMethodInfoPtr_AddActivity_Public_Void_ActivityTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationTemplate>.NativeClassPtr, 100669548);
			ApplicationTemplate.NativeMethodInfoPtr_RemoveActivity_Public_Void_ActivityTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationTemplate>.NativeClassPtr, 100669549);
			ApplicationTemplate.NativeMethodInfoPtr_GetOrCreateActivityWithName_Public_ActivityTemplate_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationTemplate>.NativeClassPtr, 100669550);
			ApplicationTemplate.NativeMethodInfoPtr_GetActivityWithName_Public_ActivityTemplate_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationTemplate>.NativeClassPtr, 100669551);
			ApplicationTemplate.NativeMethodInfoPtr_GetLauncherActivity_Public_ActivityTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationTemplate>.NativeClassPtr, 100669552);
			ApplicationTemplate.NativeMethodInfoPtr_ToXmlElement_Public_Virtual_Void_XmlDocument_XmlElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationTemplate>.NativeClassPtr, 100669553);
			ApplicationTemplate.NativeMethodInfoPtr_get_Activities_Public_get_Dictionary_2_Int32_ActivityTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationTemplate>.NativeClassPtr, 100669554);
		}

		// Token: 0x06002F3E RID: 12094 RVA: 0x000C9CEC File Offset: 0x000C7EEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219991, RefRangeEnd = 219992, XrefRangeStart = 219972, XrefRangeEnd = 219991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ApplicationTemplate()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ApplicationTemplate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationTemplate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F3F RID: 12095 RVA: 0x000C9D28 File Offset: 0x000C7F28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219992, XrefRangeEnd = 219996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddActivity(ActivityTemplate activity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationTemplate.NativeMethodInfoPtr_AddActivity_Public_Void_ActivityTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F40 RID: 12096 RVA: 0x000C9D6C File Offset: 0x000C7F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219996, XrefRangeEnd = 220000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveActivity(ActivityTemplate activity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationTemplate.NativeMethodInfoPtr_RemoveActivity_Public_Void_ActivityTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F41 RID: 12097 RVA: 0x000C9DB0 File Offset: 0x000C7FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220000, XrefRangeEnd = 220008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActivityTemplate GetOrCreateActivityWithName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationTemplate.NativeMethodInfoPtr_GetOrCreateActivityWithName_Public_ActivityTemplate_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActivityTemplate>(intPtr3) : null;
			}
		}

		// Token: 0x06002F42 RID: 12098 RVA: 0x000C9E00 File Offset: 0x000C8000
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 220026, RefRangeEnd = 220027, XrefRangeStart = 220008, XrefRangeEnd = 220026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActivityTemplate GetActivityWithName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationTemplate.NativeMethodInfoPtr_GetActivityWithName_Public_ActivityTemplate_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActivityTemplate>(intPtr3) : null;
			}
		}

		// Token: 0x06002F43 RID: 12099 RVA: 0x000C9E50 File Offset: 0x000C8050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220027, XrefRangeEnd = 220044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActivityTemplate GetLauncherActivity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationTemplate.NativeMethodInfoPtr_GetLauncherActivity_Public_ActivityTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActivityTemplate>(intPtr3) : null;
		}

		// Token: 0x06002F44 RID: 12100 RVA: 0x000C9E90 File Offset: 0x000C8090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220044, XrefRangeEnd = 220069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ToXmlElement(XmlDocument doc, XmlElement parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(doc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ApplicationTemplate.NativeMethodInfoPtr_ToXmlElement_Public_Virtual_Void_XmlDocument_XmlElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x06002F45 RID: 12101 RVA: 0x000C9EF0 File Offset: 0x000C80F0
		public unsafe Dictionary<int, ActivityTemplate> Activities
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationTemplate.NativeMethodInfoPtr_get_Activities_Public_get_Dictionary_2_Int32_ActivityTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ActivityTemplate>>(intPtr3) : null;
			}
		}

		// Token: 0x06002F46 RID: 12102 RVA: 0x00012113 File Offset: 0x00010313
		public ApplicationTemplate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x06002F47 RID: 12103 RVA: 0x000C9F30 File Offset: 0x000C8130
		// (set) Token: 0x06002F48 RID: 12104 RVA: 0x0001211C File Offset: 0x0001031C
		public unsafe Dictionary<int, ActivityTemplate> _activities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplicationTemplate.NativeFieldInfoPtr__activities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ActivityTemplate>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplicationTemplate.NativeFieldInfoPtr__activities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002CFA RID: 11514
		private static readonly IntPtr NativeFieldInfoPtr__activities;

		// Token: 0x04002CFB RID: 11515
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002CFC RID: 11516
		private static readonly IntPtr NativeMethodInfoPtr_AddActivity_Public_Void_ActivityTemplate_0;

		// Token: 0x04002CFD RID: 11517
		private static readonly IntPtr NativeMethodInfoPtr_RemoveActivity_Public_Void_ActivityTemplate_0;

		// Token: 0x04002CFE RID: 11518
		private static readonly IntPtr NativeMethodInfoPtr_GetOrCreateActivityWithName_Public_ActivityTemplate_String_0;

		// Token: 0x04002CFF RID: 11519
		private static readonly IntPtr NativeMethodInfoPtr_GetActivityWithName_Public_ActivityTemplate_String_0;

		// Token: 0x04002D00 RID: 11520
		private static readonly IntPtr NativeMethodInfoPtr_GetLauncherActivity_Public_ActivityTemplate_0;

		// Token: 0x04002D01 RID: 11521
		private static readonly IntPtr NativeMethodInfoPtr_ToXmlElement_Public_Virtual_Void_XmlDocument_XmlElement_0;

		// Token: 0x04002D02 RID: 11522
		private static readonly IntPtr NativeMethodInfoPtr_get_Activities_Public_get_Dictionary_2_Int32_ActivityTemplate_0;
	}
}
