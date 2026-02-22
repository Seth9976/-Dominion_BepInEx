using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace SA.Fitness
{
	// Token: 0x02000343 RID: 835
	public class Session : Object
	{
		// Token: 0x06003271 RID: 12913 RVA: 0x000D2E60 File Offset: 0x000D1060
		// Note: this type is marked as 'beforefieldinit'.
		static Session()
		{
			Il2CppClassPointerStore<Session>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Fitness", "Session");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Session>.NativeClassPtr);
			Session.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session>.NativeClassPtr, "Id");
			Session.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session>.NativeClassPtr, "StartTime");
			Session.NativeFieldInfoPtr_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session>.NativeClassPtr, "EndTime");
			Session.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session>.NativeClassPtr, "Name");
			Session.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session>.NativeClassPtr, "Description");
			Session.NativeFieldInfoPtr_AppPackageName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session>.NativeClassPtr, "AppPackageName");
			Session.NativeFieldInfoPtr_Activity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session>.NativeClassPtr, "Activity");
			Session.NativeFieldInfoPtr_dataSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session>.NativeClassPtr, "dataSets");
			Session.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session>.NativeClassPtr, 100669777);
			Session.NativeMethodInfoPtr_AddDataSet_Public_Void_DataSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session>.NativeClassPtr, 100669778);
			Session.NativeMethodInfoPtr_get_DataSets_Public_get_List_1_DataSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session>.NativeClassPtr, 100669779);
		}

		// Token: 0x06003272 RID: 12914 RVA: 0x000D2F6C File Offset: 0x000D116C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 222579, RefRangeEnd = 222581, XrefRangeStart = 222563, XrefRangeEnd = 222579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Session()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Session>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Session.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003273 RID: 12915 RVA: 0x000D2FA8 File Offset: 0x000D11A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222585, RefRangeEnd = 222586, XrefRangeStart = 222581, XrefRangeEnd = 222585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDataSet(DataSet data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Session.NativeMethodInfoPtr_AddDataSet_Public_Void_DataSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x06003274 RID: 12916 RVA: 0x000D2FEC File Offset: 0x000D11EC
		public unsafe List<DataSet> DataSets
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Session.NativeMethodInfoPtr_get_DataSets_Public_get_List_1_DataSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DataSet>>(intPtr3) : null;
			}
		}

		// Token: 0x06003275 RID: 12917 RVA: 0x00013915 File Offset: 0x00011B15
		public Session(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x06003276 RID: 12918 RVA: 0x000D302C File Offset: 0x000D122C
		// (set) Token: 0x06003277 RID: 12919 RVA: 0x0001391E File Offset: 0x00011B1E
		public unsafe string Id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Session.NativeFieldInfoPtr_Id);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Session.NativeFieldInfoPtr_Id), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x06003278 RID: 12920 RVA: 0x000D3054 File Offset: 0x000D1254
		// (set) Token: 0x06003279 RID: 12921 RVA: 0x0001393D File Offset: 0x00011B3D
		public unsafe long StartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Session.NativeFieldInfoPtr_StartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Session.NativeFieldInfoPtr_StartTime)) = value;
			}
		}

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x0600327A RID: 12922 RVA: 0x000D307C File Offset: 0x000D127C
		// (set) Token: 0x0600327B RID: 12923 RVA: 0x00013958 File Offset: 0x00011B58
		public unsafe long EndTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Session.NativeFieldInfoPtr_EndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Session.NativeFieldInfoPtr_EndTime)) = value;
			}
		}

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x0600327C RID: 12924 RVA: 0x000D30A4 File Offset: 0x000D12A4
		// (set) Token: 0x0600327D RID: 12925 RVA: 0x00013973 File Offset: 0x00011B73
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Session.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Session.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x0600327E RID: 12926 RVA: 0x000D30CC File Offset: 0x000D12CC
		// (set) Token: 0x0600327F RID: 12927 RVA: 0x00013992 File Offset: 0x00011B92
		public unsafe string Description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Session.NativeFieldInfoPtr_Description);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Session.NativeFieldInfoPtr_Description), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x06003280 RID: 12928 RVA: 0x000D30F4 File Offset: 0x000D12F4
		// (set) Token: 0x06003281 RID: 12929 RVA: 0x000139B1 File Offset: 0x00011BB1
		public unsafe string AppPackageName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Session.NativeFieldInfoPtr_AppPackageName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Session.NativeFieldInfoPtr_AppPackageName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x06003282 RID: 12930 RVA: 0x000D311C File Offset: 0x000D131C
		// (set) Token: 0x06003283 RID: 12931 RVA: 0x000139D0 File Offset: 0x00011BD0
		public unsafe Activity Activity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Session.NativeFieldInfoPtr_Activity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Session.NativeFieldInfoPtr_Activity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x06003284 RID: 12932 RVA: 0x000D314C File Offset: 0x000D134C
		// (set) Token: 0x06003285 RID: 12933 RVA: 0x000139EF File Offset: 0x00011BEF
		public unsafe List<DataSet> dataSets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Session.NativeFieldInfoPtr_dataSets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DataSet>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Session.NativeFieldInfoPtr_dataSets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002F35 RID: 12085
		private static readonly IntPtr NativeFieldInfoPtr_Id;

		// Token: 0x04002F36 RID: 12086
		private static readonly IntPtr NativeFieldInfoPtr_StartTime;

		// Token: 0x04002F37 RID: 12087
		private static readonly IntPtr NativeFieldInfoPtr_EndTime;

		// Token: 0x04002F38 RID: 12088
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04002F39 RID: 12089
		private static readonly IntPtr NativeFieldInfoPtr_Description;

		// Token: 0x04002F3A RID: 12090
		private static readonly IntPtr NativeFieldInfoPtr_AppPackageName;

		// Token: 0x04002F3B RID: 12091
		private static readonly IntPtr NativeFieldInfoPtr_Activity;

		// Token: 0x04002F3C RID: 12092
		private static readonly IntPtr NativeFieldInfoPtr_dataSets;

		// Token: 0x04002F3D RID: 12093
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002F3E RID: 12094
		private static readonly IntPtr NativeMethodInfoPtr_AddDataSet_Public_Void_DataSet_0;

		// Token: 0x04002F3F RID: 12095
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSets_Public_get_List_1_DataSet_0;
	}
}
