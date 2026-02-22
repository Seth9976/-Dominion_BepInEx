using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020000A0 RID: 160
	public class PropagationPaths : Object
	{
		// Token: 0x0600086B RID: 2155 RVA: 0x00027DB0 File Offset: 0x00025FB0
		// Note: this type is marked as 'beforefieldinit'.
		static PropagationPaths()
		{
			Il2CppClassPointerStore<PropagationPaths>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PropagationPaths");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropagationPaths>.NativeClassPtr);
			PropagationPaths.NativeFieldInfoPtr_s_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropagationPaths>.NativeClassPtr, "s_Pool");
			PropagationPaths.NativeFieldInfoPtr_trickleDownPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropagationPaths>.NativeClassPtr, "trickleDownPath");
			PropagationPaths.NativeFieldInfoPtr_targetElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropagationPaths>.NativeClassPtr, "targetElements");
			PropagationPaths.NativeFieldInfoPtr_bubbleUpPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropagationPaths>.NativeClassPtr, "bubbleUpPath");
			PropagationPaths.NativeFieldInfoPtr_k_DefaultPropagationDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropagationPaths>.NativeClassPtr, "k_DefaultPropagationDepth");
			PropagationPaths.NativeFieldInfoPtr_k_DefaultTargetCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropagationPaths>.NativeClassPtr, "k_DefaultTargetCount");
			PropagationPaths.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropagationPaths>.NativeClassPtr, 100664126);
			PropagationPaths.NativeMethodInfoPtr_Copy_Internal_Static_PropagationPaths_PropagationPaths_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropagationPaths>.NativeClassPtr, 100664127);
			PropagationPaths.NativeMethodInfoPtr_Build_Public_Static_PropagationPaths_VisualElement_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropagationPaths>.NativeClassPtr, 100664128);
			PropagationPaths.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropagationPaths>.NativeClassPtr, 100664129);
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x00027EA8 File Offset: 0x000260A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96502, XrefRangeEnd = 96517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropagationPaths()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropagationPaths>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropagationPaths.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00027EE4 File Offset: 0x000260E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96517, XrefRangeEnd = 96531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropagationPaths Copy(PropagationPaths paths)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(paths);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropagationPaths.NativeMethodInfoPtr_Copy_Internal_Static_PropagationPaths_PropagationPaths_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropagationPaths>(intPtr3) : null;
			}
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00027F28 File Offset: 0x00026128
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 96557, RefRangeEnd = 96558, XrefRangeStart = 96531, XrefRangeEnd = 96557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropagationPaths Build(VisualElement elem, PropagationPaths.Type pathTypesRequested)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pathTypesRequested;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropagationPaths.NativeMethodInfoPtr_Build_Public_Static_PropagationPaths_VisualElement_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropagationPaths>(intPtr3) : null;
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00027F7C File Offset: 0x0002617C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96558, XrefRangeEnd = 96581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropagationPaths.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x0000583E File Offset: 0x00003A3E
		public PropagationPaths(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x00027FB0 File Offset: 0x000261B0
		// (set) Token: 0x06000872 RID: 2162 RVA: 0x00005847 File Offset: 0x00003A47
		public unsafe static ObjectPool<PropagationPaths> s_Pool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PropagationPaths.NativeFieldInfoPtr_s_Pool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<PropagationPaths>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PropagationPaths.NativeFieldInfoPtr_s_Pool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000873 RID: 2163 RVA: 0x00027FD8 File Offset: 0x000261D8
		// (set) Token: 0x06000874 RID: 2164 RVA: 0x00005859 File Offset: 0x00003A59
		public unsafe List<VisualElement> trickleDownPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropagationPaths.NativeFieldInfoPtr_trickleDownPath);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VisualElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropagationPaths.NativeFieldInfoPtr_trickleDownPath), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x00028008 File Offset: 0x00026208
		// (set) Token: 0x06000876 RID: 2166 RVA: 0x00005878 File Offset: 0x00003A78
		public unsafe List<VisualElement> targetElements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropagationPaths.NativeFieldInfoPtr_targetElements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VisualElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropagationPaths.NativeFieldInfoPtr_targetElements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x00028038 File Offset: 0x00026238
		// (set) Token: 0x06000878 RID: 2168 RVA: 0x00005897 File Offset: 0x00003A97
		public unsafe List<VisualElement> bubbleUpPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropagationPaths.NativeFieldInfoPtr_bubbleUpPath);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VisualElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropagationPaths.NativeFieldInfoPtr_bubbleUpPath), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000879 RID: 2169 RVA: 0x00028068 File Offset: 0x00026268
		// (set) Token: 0x0600087A RID: 2170 RVA: 0x000058B6 File Offset: 0x00003AB6
		public unsafe static int k_DefaultPropagationDepth
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PropagationPaths.NativeFieldInfoPtr_k_DefaultPropagationDepth, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PropagationPaths.NativeFieldInfoPtr_k_DefaultPropagationDepth, (void*)(&value));
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x0600087B RID: 2171 RVA: 0x00028084 File Offset: 0x00026284
		// (set) Token: 0x0600087C RID: 2172 RVA: 0x000058C4 File Offset: 0x00003AC4
		public unsafe static int k_DefaultTargetCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PropagationPaths.NativeFieldInfoPtr_k_DefaultTargetCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PropagationPaths.NativeFieldInfoPtr_k_DefaultTargetCount, (void*)(&value));
			}
		}

		// Token: 0x040004C7 RID: 1223
		private static readonly IntPtr NativeFieldInfoPtr_s_Pool;

		// Token: 0x040004C8 RID: 1224
		private static readonly IntPtr NativeFieldInfoPtr_trickleDownPath;

		// Token: 0x040004C9 RID: 1225
		private static readonly IntPtr NativeFieldInfoPtr_targetElements;

		// Token: 0x040004CA RID: 1226
		private static readonly IntPtr NativeFieldInfoPtr_bubbleUpPath;

		// Token: 0x040004CB RID: 1227
		private static readonly IntPtr NativeFieldInfoPtr_k_DefaultPropagationDepth;

		// Token: 0x040004CC RID: 1228
		private static readonly IntPtr NativeFieldInfoPtr_k_DefaultTargetCount;

		// Token: 0x040004CD RID: 1229
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040004CE RID: 1230
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Internal_Static_PropagationPaths_PropagationPaths_0;

		// Token: 0x040004CF RID: 1231
		private static readonly IntPtr NativeMethodInfoPtr_Build_Public_Static_PropagationPaths_VisualElement_Type_0;

		// Token: 0x040004D0 RID: 1232
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

		// Token: 0x02000219 RID: 537
		[Flags]
		public enum Type
		{
			// Token: 0x040008C7 RID: 2247
			None = 0,
			// Token: 0x040008C8 RID: 2248
			TrickleDown = 1,
			// Token: 0x040008C9 RID: 2249
			BubbleUp = 2
		}
	}
}
