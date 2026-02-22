using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml;

namespace SA.Manifest
{
	// Token: 0x02000321 RID: 801
	public class ActivityTemplate : BaseTemplate
	{
		// Token: 0x06002F2A RID: 12074 RVA: 0x000C97C0 File Offset: 0x000C79C0
		// Note: this type is marked as 'beforefieldinit'.
		static ActivityTemplate()
		{
			Il2CppClassPointerStore<ActivityTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Manifest", "ActivityTemplate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivityTemplate>.NativeClassPtr);
			ActivityTemplate.NativeFieldInfoPtr_IsOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityTemplate>.NativeClassPtr, "IsOpen");
			ActivityTemplate.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityTemplate>.NativeClassPtr, "_id");
			ActivityTemplate.NativeFieldInfoPtr__isLauncher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityTemplate>.NativeClassPtr, "_isLauncher");
			ActivityTemplate.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivityTemplate>.NativeClassPtr, "_name");
			ActivityTemplate.NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTemplate>.NativeClassPtr, 100669538);
			ActivityTemplate.NativeMethodInfoPtr_SetName_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTemplate>.NativeClassPtr, 100669539);
			ActivityTemplate.NativeMethodInfoPtr_SetAsLauncher_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTemplate>.NativeClassPtr, 100669540);
			ActivityTemplate.NativeMethodInfoPtr_GetLauncherPropertyTemplate_Public_Static_PropertyTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTemplate>.NativeClassPtr, 100669541);
			ActivityTemplate.NativeMethodInfoPtr_IsLauncherProperty_Public_Boolean_PropertyTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTemplate>.NativeClassPtr, 100669542);
			ActivityTemplate.NativeMethodInfoPtr_ToXmlElement_Public_Virtual_Void_XmlDocument_XmlElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTemplate>.NativeClassPtr, 100669543);
			ActivityTemplate.NativeMethodInfoPtr_get_IsLauncher_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTemplate>.NativeClassPtr, 100669544);
			ActivityTemplate.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTemplate>.NativeClassPtr, 100669545);
			ActivityTemplate.NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivityTemplate>.NativeClassPtr, 100669546);
		}

		// Token: 0x06002F2B RID: 12075 RVA: 0x000C98F4 File Offset: 0x000C7AF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219859, RefRangeEnd = 219860, XrefRangeStart = 219841, XrefRangeEnd = 219859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActivityTemplate(bool isLauncher, string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivityTemplate>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isLauncher;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityTemplate.NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F2C RID: 12076 RVA: 0x000C9950 File Offset: 0x000C7B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219860, XrefRangeEnd = 219863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityTemplate.NativeMethodInfoPtr_SetName_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F2D RID: 12077 RVA: 0x000C9994 File Offset: 0x000C7B94
		[CallerCount(0)]
		public unsafe void SetAsLauncher(bool isLauncher)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isLauncher;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityTemplate.NativeMethodInfoPtr_SetAsLauncher_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F2E RID: 12078 RVA: 0x000C99D4 File Offset: 0x000C7BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219863, XrefRangeEnd = 219892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertyTemplate GetLauncherPropertyTemplate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityTemplate.NativeMethodInfoPtr_GetLauncherPropertyTemplate_Public_Static_PropertyTemplate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyTemplate>(intPtr3) : null;
		}

		// Token: 0x06002F2F RID: 12079 RVA: 0x000C9A08 File Offset: 0x000C7C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219892, XrefRangeEnd = 219932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsLauncherProperty(PropertyTemplate property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityTemplate.NativeMethodInfoPtr_IsLauncherProperty_Public_Boolean_PropertyTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002F30 RID: 12080 RVA: 0x000C9A58 File Offset: 0x000C7C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219932, XrefRangeEnd = 219972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActivityTemplate.NativeMethodInfoPtr_ToXmlElement_Public_Virtual_Void_XmlDocument_XmlElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x06002F31 RID: 12081 RVA: 0x000C9AB8 File Offset: 0x000C7CB8
		public unsafe bool IsLauncher
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityTemplate.NativeMethodInfoPtr_get_IsLauncher_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x06002F32 RID: 12082 RVA: 0x000C9AF4 File Offset: 0x000C7CF4
		public unsafe string Name
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityTemplate.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x06002F33 RID: 12083 RVA: 0x000C9B2C File Offset: 0x000C7D2C
		public unsafe int Id
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivityTemplate.NativeMethodInfoPtr_get_Id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002F34 RID: 12084 RVA: 0x0001209A File Offset: 0x0001029A
		public ActivityTemplate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x06002F35 RID: 12085 RVA: 0x000C9B68 File Offset: 0x000C7D68
		// (set) Token: 0x06002F36 RID: 12086 RVA: 0x000120A3 File Offset: 0x000102A3
		public unsafe bool IsOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTemplate.NativeFieldInfoPtr_IsOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTemplate.NativeFieldInfoPtr_IsOpen)) = value;
			}
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x06002F37 RID: 12087 RVA: 0x000C9B90 File Offset: 0x000C7D90
		// (set) Token: 0x06002F38 RID: 12088 RVA: 0x000120BE File Offset: 0x000102BE
		public unsafe int _id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTemplate.NativeFieldInfoPtr__id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTemplate.NativeFieldInfoPtr__id)) = value;
			}
		}

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x06002F39 RID: 12089 RVA: 0x000C9BB8 File Offset: 0x000C7DB8
		// (set) Token: 0x06002F3A RID: 12090 RVA: 0x000120D9 File Offset: 0x000102D9
		public unsafe bool _isLauncher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTemplate.NativeFieldInfoPtr__isLauncher);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTemplate.NativeFieldInfoPtr__isLauncher)) = value;
			}
		}

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x06002F3B RID: 12091 RVA: 0x000C9BE0 File Offset: 0x000C7DE0
		// (set) Token: 0x06002F3C RID: 12092 RVA: 0x000120F4 File Offset: 0x000102F4
		public unsafe string _name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTemplate.NativeFieldInfoPtr__name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivityTemplate.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002CED RID: 11501
		private static readonly IntPtr NativeFieldInfoPtr_IsOpen;

		// Token: 0x04002CEE RID: 11502
		private static readonly IntPtr NativeFieldInfoPtr__id;

		// Token: 0x04002CEF RID: 11503
		private static readonly IntPtr NativeFieldInfoPtr__isLauncher;

		// Token: 0x04002CF0 RID: 11504
		private static readonly IntPtr NativeFieldInfoPtr__name;

		// Token: 0x04002CF1 RID: 11505
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_0;

		// Token: 0x04002CF2 RID: 11506
		private static readonly IntPtr NativeMethodInfoPtr_SetName_Public_Void_String_0;

		// Token: 0x04002CF3 RID: 11507
		private static readonly IntPtr NativeMethodInfoPtr_SetAsLauncher_Public_Void_Boolean_0;

		// Token: 0x04002CF4 RID: 11508
		private static readonly IntPtr NativeMethodInfoPtr_GetLauncherPropertyTemplate_Public_Static_PropertyTemplate_0;

		// Token: 0x04002CF5 RID: 11509
		private static readonly IntPtr NativeMethodInfoPtr_IsLauncherProperty_Public_Boolean_PropertyTemplate_0;

		// Token: 0x04002CF6 RID: 11510
		private static readonly IntPtr NativeMethodInfoPtr_ToXmlElement_Public_Virtual_Void_XmlDocument_XmlElement_0;

		// Token: 0x04002CF7 RID: 11511
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLauncher_Public_get_Boolean_0;

		// Token: 0x04002CF8 RID: 11512
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04002CF9 RID: 11513
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;
	}
}
