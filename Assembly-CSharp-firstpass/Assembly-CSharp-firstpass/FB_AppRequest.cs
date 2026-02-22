using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x02000090 RID: 144
public class FB_AppRequest : Object
{
	// Token: 0x06000A89 RID: 2697 RVA: 0x0003C59C File Offset: 0x0003A79C
	// Note: this type is marked as 'beforefieldinit'.
	static FB_AppRequest()
	{
		Il2CppClassPointerStore<FB_AppRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "FB_AppRequest");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FB_AppRequest>.NativeClassPtr);
		FB_AppRequest.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_AppRequest>.NativeClassPtr, "Id");
		FB_AppRequest.NativeFieldInfoPtr_ApplicationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_AppRequest>.NativeClassPtr, "ApplicationId");
		FB_AppRequest.NativeFieldInfoPtr_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_AppRequest>.NativeClassPtr, "Message");
		FB_AppRequest.NativeFieldInfoPtr_ActionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_AppRequest>.NativeClassPtr, "ActionType");
		FB_AppRequest.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_AppRequest>.NativeClassPtr, "State");
		FB_AppRequest.NativeFieldInfoPtr_FromId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_AppRequest>.NativeClassPtr, "FromId");
		FB_AppRequest.NativeFieldInfoPtr_FromName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_AppRequest>.NativeClassPtr, "FromName");
		FB_AppRequest.NativeFieldInfoPtr_CreatedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_AppRequest>.NativeClassPtr, "CreatedTime");
		FB_AppRequest.NativeFieldInfoPtr_CreatedTimeString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_AppRequest>.NativeClassPtr, "CreatedTimeString");
		FB_AppRequest.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_AppRequest>.NativeClassPtr, "Data");
		FB_AppRequest.NativeFieldInfoPtr_Object = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_AppRequest>.NativeClassPtr, "Object");
		FB_AppRequest.NativeFieldInfoPtr_OnDeleteRequestFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_AppRequest>.NativeClassPtr, "OnDeleteRequestFinished");
		FB_AppRequest.NativeMethodInfoPtr_SetCreatedTime_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_AppRequest>.NativeClassPtr, 100664601);
		FB_AppRequest.NativeMethodInfoPtr_Delete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_AppRequest>.NativeClassPtr, 100664602);
		FB_AppRequest.NativeMethodInfoPtr_OnDeleteActionFinish_Private_Void_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_AppRequest>.NativeClassPtr, 100664603);
		FB_AppRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_AppRequest>.NativeClassPtr, 100664604);
	}

	// Token: 0x06000A8A RID: 2698 RVA: 0x0003C70C File Offset: 0x0003A90C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 173488, RefRangeEnd = 173489, XrefRangeStart = 173484, XrefRangeEnd = 173488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCreatedTime(string time_string)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(time_string);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_AppRequest.NativeMethodInfoPtr_SetCreatedTime_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000A8B RID: 2699 RVA: 0x0003C750 File Offset: 0x0003A950
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173489, XrefRangeEnd = 173505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Delete()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_AppRequest.NativeMethodInfoPtr_Delete_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A8C RID: 2700 RVA: 0x0003C784 File Offset: 0x0003A984
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173505, XrefRangeEnd = 173509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDeleteActionFinish(FB_Result result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_AppRequest.NativeMethodInfoPtr_OnDeleteActionFinish_Private_Void_FB_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000A8D RID: 2701 RVA: 0x0003C7C8 File Offset: 0x0003A9C8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 173528, RefRangeEnd = 173529, XrefRangeStart = 173509, XrefRangeEnd = 173528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FB_AppRequest()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FB_AppRequest>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_AppRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A8E RID: 2702 RVA: 0x00006114 File Offset: 0x00004314
	public FB_AppRequest(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700034D RID: 845
	// (get) Token: 0x06000A8F RID: 2703 RVA: 0x0003C804 File Offset: 0x0003AA04
	// (set) Token: 0x06000A90 RID: 2704 RVA: 0x0000611D File Offset: 0x0000431D
	public unsafe string Id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_AppRequest.NativeFieldInfoPtr_Id);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_AppRequest.NativeFieldInfoPtr_Id), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700034E RID: 846
	// (get) Token: 0x06000A91 RID: 2705 RVA: 0x0003C82C File Offset: 0x0003AA2C
	// (set) Token: 0x06000A92 RID: 2706 RVA: 0x0000613C File Offset: 0x0000433C
	public unsafe string ApplicationId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_AppRequest.NativeFieldInfoPtr_ApplicationId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_AppRequest.NativeFieldInfoPtr_ApplicationId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700034F RID: 847
	// (get) Token: 0x06000A93 RID: 2707 RVA: 0x0003C854 File Offset: 0x0003AA54
	// (set) Token: 0x06000A94 RID: 2708 RVA: 0x0000615B File Offset: 0x0000435B
	public unsafe string Message
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_AppRequest.NativeFieldInfoPtr_Message);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_AppRequest.NativeFieldInfoPtr_Message), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000350 RID: 848
	// (get) Token: 0x06000A95 RID: 2709 RVA: 0x0003C87C File Offset: 0x0003AA7C
	// (set) Token: 0x06000A96 RID: 2710 RVA: 0x0000617A File Offset: 0x0000437A
	public unsafe FB_RequestActionType ActionType
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_AppRequest.NativeFieldInfoPtr_ActionType);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_AppRequest.NativeFieldInfoPtr_ActionType)) = value;
		}
	}

	// Token: 0x17000351 RID: 849
	// (get) Token: 0x06000A97 RID: 2711 RVA: 0x0003C8A4 File Offset: 0x0003AAA4
	// (set) Token: 0x06000A98 RID: 2712 RVA: 0x00006195 File Offset: 0x00004395
	public unsafe FB_AppRequestState State
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_AppRequest.NativeFieldInfoPtr_State);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_AppRequest.NativeFieldInfoPtr_State)) = value;
		}
	}

	// Token: 0x17000352 RID: 850
	// (get) Token: 0x06000A99 RID: 2713 RVA: 0x0003C8CC File Offset: 0x0003AACC
	// (set) Token: 0x06000A9A RID: 2714 RVA: 0x000061B0 File Offset: 0x000043B0
	public unsafe string FromId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_AppRequest.NativeFieldInfoPtr_FromId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_AppRequest.NativeFieldInfoPtr_FromId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000353 RID: 851
	// (get) Token: 0x06000A9B RID: 2715 RVA: 0x0003C8F4 File Offset: 0x0003AAF4
	// (set) Token: 0x06000A9C RID: 2716 RVA: 0x000061CF File Offset: 0x000043CF
	public unsafe string FromName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_AppRequest.NativeFieldInfoPtr_FromName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_AppRequest.NativeFieldInfoPtr_FromName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000354 RID: 852
	// (get) Token: 0x06000A9D RID: 2717 RVA: 0x0003C91C File Offset: 0x0003AB1C
	// (set) Token: 0x06000A9E RID: 2718 RVA: 0x000061EE File Offset: 0x000043EE
	public unsafe DateTime CreatedTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_AppRequest.NativeFieldInfoPtr_CreatedTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_AppRequest.NativeFieldInfoPtr_CreatedTime)) = value;
		}
	}

	// Token: 0x17000355 RID: 853
	// (get) Token: 0x06000A9F RID: 2719 RVA: 0x0003C944 File Offset: 0x0003AB44
	// (set) Token: 0x06000AA0 RID: 2720 RVA: 0x00006209 File Offset: 0x00004409
	public unsafe string CreatedTimeString
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_AppRequest.NativeFieldInfoPtr_CreatedTimeString);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_AppRequest.NativeFieldInfoPtr_CreatedTimeString), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000356 RID: 854
	// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x0003C96C File Offset: 0x0003AB6C
	// (set) Token: 0x06000AA2 RID: 2722 RVA: 0x00006228 File Offset: 0x00004428
	public unsafe string Data
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_AppRequest.NativeFieldInfoPtr_Data);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_AppRequest.NativeFieldInfoPtr_Data), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000357 RID: 855
	// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x0003C994 File Offset: 0x0003AB94
	// (set) Token: 0x06000AA4 RID: 2724 RVA: 0x00006247 File Offset: 0x00004447
	public unsafe FB_Object Object
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_AppRequest.NativeFieldInfoPtr_Object);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<FB_Object>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_AppRequest.NativeFieldInfoPtr_Object), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000358 RID: 856
	// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x0003C9C4 File Offset: 0x0003ABC4
	// (set) Token: 0x06000AA6 RID: 2726 RVA: 0x00006266 File Offset: 0x00004466
	public unsafe Action<FB_Result> OnDeleteRequestFinished
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_AppRequest.NativeFieldInfoPtr_OnDeleteRequestFinished);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<FB_Result>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_AppRequest.NativeFieldInfoPtr_OnDeleteRequestFinished), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000879 RID: 2169
	private static readonly IntPtr NativeFieldInfoPtr_Id;

	// Token: 0x0400087A RID: 2170
	private static readonly IntPtr NativeFieldInfoPtr_ApplicationId;

	// Token: 0x0400087B RID: 2171
	private static readonly IntPtr NativeFieldInfoPtr_Message;

	// Token: 0x0400087C RID: 2172
	private static readonly IntPtr NativeFieldInfoPtr_ActionType;

	// Token: 0x0400087D RID: 2173
	private static readonly IntPtr NativeFieldInfoPtr_State;

	// Token: 0x0400087E RID: 2174
	private static readonly IntPtr NativeFieldInfoPtr_FromId;

	// Token: 0x0400087F RID: 2175
	private static readonly IntPtr NativeFieldInfoPtr_FromName;

	// Token: 0x04000880 RID: 2176
	private static readonly IntPtr NativeFieldInfoPtr_CreatedTime;

	// Token: 0x04000881 RID: 2177
	private static readonly IntPtr NativeFieldInfoPtr_CreatedTimeString;

	// Token: 0x04000882 RID: 2178
	private static readonly IntPtr NativeFieldInfoPtr_Data;

	// Token: 0x04000883 RID: 2179
	private static readonly IntPtr NativeFieldInfoPtr_Object;

	// Token: 0x04000884 RID: 2180
	private static readonly IntPtr NativeFieldInfoPtr_OnDeleteRequestFinished;

	// Token: 0x04000885 RID: 2181
	private static readonly IntPtr NativeMethodInfoPtr_SetCreatedTime_Public_Void_String_0;

	// Token: 0x04000886 RID: 2182
	private static readonly IntPtr NativeMethodInfoPtr_Delete_Public_Void_0;

	// Token: 0x04000887 RID: 2183
	private static readonly IntPtr NativeMethodInfoPtr_OnDeleteActionFinish_Private_Void_FB_Result_0;

	// Token: 0x04000888 RID: 2184
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200037D RID: 893
	[ObfuscatedName("FB_AppRequest+<>c")]
	[Serializable]
	public sealed class __c : Object
	{
		// Token: 0x0600355E RID: 13662 RVA: 0x000DC450 File Offset: 0x000DA650
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<FB_AppRequest.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FB_AppRequest>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FB_AppRequest.__c>.NativeClassPtr);
			FB_AppRequest.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_AppRequest.__c>.NativeClassPtr, "<>9");
			FB_AppRequest.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_AppRequest.__c>.NativeClassPtr, "<>9__15_0");
			FB_AppRequest.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_AppRequest.__c>.NativeClassPtr, 100670115);
			FB_AppRequest.__c.NativeMethodInfoPtr___ctor_b__15_0_Internal_Void_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_AppRequest.__c>.NativeClassPtr, 100670116);
		}

		// Token: 0x0600355F RID: 13663 RVA: 0x000DC4CC File Offset: 0x000DA6CC
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FB_AppRequest.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_AppRequest.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003560 RID: 13664 RVA: 0x000DC508 File Offset: 0x000DA708
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__15_0(FB_Result <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_AppRequest.__c.NativeMethodInfoPtr___ctor_b__15_0_Internal_Void_FB_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003561 RID: 13665 RVA: 0x00014AD8 File Offset: 0x00012CD8
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x06003562 RID: 13666 RVA: 0x000DC54C File Offset: 0x000DA74C
		// (set) Token: 0x06003563 RID: 13667 RVA: 0x00014AE1 File Offset: 0x00012CE1
		public unsafe static FB_AppRequest.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FB_AppRequest.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FB_AppRequest.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FB_AppRequest.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x06003564 RID: 13668 RVA: 0x000DC574 File Offset: 0x000DA774
		// (set) Token: 0x06003565 RID: 13669 RVA: 0x00014AF3 File Offset: 0x00012CF3
		public unsafe static Action<FB_Result> __9__15_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FB_AppRequest.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<FB_Result>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FB_AppRequest.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400312D RID: 12589
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x0400312E RID: 12590
		private static readonly IntPtr NativeFieldInfoPtr___9__15_0;

		// Token: 0x0400312F RID: 12591
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003130 RID: 12592
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__15_0_Internal_Void_FB_Result_0;
	}
}
