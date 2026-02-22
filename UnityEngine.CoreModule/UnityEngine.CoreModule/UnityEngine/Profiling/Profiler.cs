using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine.Profiling
{
	// Token: 0x02000252 RID: 594
	public sealed class Profiler
	{
		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06001F8C RID: 8076 RVA: 0x00012297 File Offset: 0x00010497
		public static bool supported
		{
			get
			{
				return Profiler.get_supportedDelegateField();
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06001F8D RID: 8077 RVA: 0x00066B1C File Offset: 0x00064D1C
		// (set) Token: 0x06001F8E RID: 8078 RVA: 0x000122A3 File Offset: 0x000104A3
		public static string logFile
		{
			get
			{
				IntPtr intPtr = Profiler.get_logFileDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				Profiler.set_logFileDelegateField(IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06001F8F RID: 8079 RVA: 0x000122B5 File Offset: 0x000104B5
		// (set) Token: 0x06001F90 RID: 8080 RVA: 0x000122C1 File Offset: 0x000104C1
		public static bool enableBinaryLog
		{
			get
			{
				return Profiler.get_enableBinaryLogDelegateField();
			}
			set
			{
				Profiler.set_enableBinaryLogDelegateField(value);
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06001F91 RID: 8081 RVA: 0x000122CE File Offset: 0x000104CE
		// (set) Token: 0x06001F92 RID: 8082 RVA: 0x000122DA File Offset: 0x000104DA
		public static int maxUsedMemory
		{
			get
			{
				return Profiler.get_maxUsedMemoryDelegateField();
			}
			set
			{
				Profiler.set_maxUsedMemoryDelegateField(value);
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06001F93 RID: 8083 RVA: 0x000122E7 File Offset: 0x000104E7
		// (set) Token: 0x06001F94 RID: 8084 RVA: 0x000122F3 File Offset: 0x000104F3
		public static bool enabled
		{
			get
			{
				return Profiler.get_enabledDelegateField();
			}
			set
			{
				Profiler.set_enabledDelegateField(value);
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06001F95 RID: 8085 RVA: 0x00012300 File Offset: 0x00010500
		// (set) Token: 0x06001F96 RID: 8086 RVA: 0x0001230C File Offset: 0x0001050C
		public static bool enableAllocationCallstacks
		{
			get
			{
				return Profiler.get_enableAllocationCallstacksDelegateField();
			}
			set
			{
				Profiler.set_enableAllocationCallstacksDelegateField(value);
			}
		}

		// Token: 0x06001F97 RID: 8087 RVA: 0x00012319 File Offset: 0x00010519
		public static void SetAreaEnabled(ProfilerArea area, bool enabled)
		{
			Profiler.SetAreaEnabledDelegateField(area, enabled);
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06001F98 RID: 8088 RVA: 0x00066B3C File Offset: 0x00064D3C
		public static int areaCount
		{
			get
			{
				return Enum.GetNames(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<ProfilerArea>())).Length;
			}
		}

		// Token: 0x06001F99 RID: 8089 RVA: 0x00012327 File Offset: 0x00010527
		public static bool GetAreaEnabled(ProfilerArea area)
		{
			return Profiler.GetAreaEnabledDelegateField(area);
		}

		// Token: 0x06001F9A RID: 8090 RVA: 0x00066B64 File Offset: 0x00064D64
		public static void AddFramesFromFile(string file)
		{
			bool flag = String.IsNullOrEmpty(file);
			if (flag)
			{
				Debug.LogError("AddFramesFromFile: Invalid or empty path");
			}
			else
			{
				Profiler.AddFramesFromFile_Internal(file, true);
			}
		}

		// Token: 0x06001F9B RID: 8091 RVA: 0x00012334 File Offset: 0x00010534
		public static void AddFramesFromFile_Internal(string file, bool keepExistingFrames)
		{
			Profiler.AddFramesFromFile_InternalDelegateField(IL2CPP.ManagedStringToIl2Cpp(file), keepExistingFrames);
		}

		// Token: 0x06001F9C RID: 8092 RVA: 0x00066B94 File Offset: 0x00064D94
		public static void BeginThreadProfiling(string threadGroupName, string threadName)
		{
			bool flag = String.IsNullOrEmpty(threadGroupName);
			if (flag)
			{
				throw new ArgumentException("Argument should be a valid string", "threadGroupName");
			}
			bool flag2 = String.IsNullOrEmpty(threadName);
			if (flag2)
			{
				throw new ArgumentException("Argument should be a valid string", "threadName");
			}
			Profiler.BeginThreadProfilingInternal(threadGroupName, threadName);
		}

		// Token: 0x06001F9D RID: 8093 RVA: 0x00012347 File Offset: 0x00010547
		public static void BeginThreadProfilingInternal(string threadGroupName, string threadName)
		{
			Profiler.BeginThreadProfilingInternalDelegateField(IL2CPP.ManagedStringToIl2Cpp(threadGroupName), IL2CPP.ManagedStringToIl2Cpp(threadName));
		}

		// Token: 0x06001F9E RID: 8094 RVA: 0x0001235F File Offset: 0x0001055F
		public static void EndThreadProfiling()
		{
		}

		// Token: 0x06001F9F RID: 8095 RVA: 0x00012362 File Offset: 0x00010562
		public static void BeginSample(string name)
		{
			Profiler.ValidateArguments(name);
			Profiler.BeginSampleImpl(name, null);
		}

		// Token: 0x06001FA0 RID: 8096 RVA: 0x00012374 File Offset: 0x00010574
		public static void BeginSample(string name, Object targetObject)
		{
			Profiler.ValidateArguments(name);
			Profiler.BeginSampleImpl(name, targetObject);
		}

		// Token: 0x06001FA1 RID: 8097 RVA: 0x00066BE0 File Offset: 0x00064DE0
		public static void ValidateArguments(string name)
		{
			bool flag = String.IsNullOrEmpty(name);
			if (flag)
			{
				throw new ArgumentException("Argument should be a valid string.", "name");
			}
		}

		// Token: 0x06001FA2 RID: 8098 RVA: 0x00012386 File Offset: 0x00010586
		public static void BeginSampleImpl(string name, Object targetObject)
		{
			Profiler.BeginSampleImplDelegateField(IL2CPP.ManagedStringToIl2Cpp(name), IL2CPP.Il2CppObjectBaseToPtr(targetObject));
		}

		// Token: 0x06001FA3 RID: 8099 RVA: 0x0001239E File Offset: 0x0001059E
		public static void EndSample()
		{
			Profiler.EndSampleDelegateField();
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06001FA4 RID: 8100 RVA: 0x00066C0C File Offset: 0x00064E0C
		// (set) Token: 0x06001FA5 RID: 8101 RVA: 0x000123AA File Offset: 0x000105AA
		public static int maxNumberOfSamplesPerFrame
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x06001FA6 RID: 8102 RVA: 0x00066C20 File Offset: 0x00064E20
		public static uint usedHeapSize
		{
			get
			{
				return (uint)Profiler.usedHeapSizeLong;
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x06001FA7 RID: 8103 RVA: 0x000123AD File Offset: 0x000105AD
		public static long usedHeapSizeLong
		{
			get
			{
				return Profiler.get_usedHeapSizeLongDelegateField();
			}
		}

		// Token: 0x06001FA8 RID: 8104 RVA: 0x00066C38 File Offset: 0x00064E38
		public static int GetRuntimeMemorySize(Object o)
		{
			return (int)Profiler.GetRuntimeMemorySizeLong(o);
		}

		// Token: 0x06001FA9 RID: 8105 RVA: 0x000123B9 File Offset: 0x000105B9
		public static long GetRuntimeMemorySizeLong(Object o)
		{
			return Profiler.GetRuntimeMemorySizeLongDelegateField(IL2CPP.Il2CppObjectBaseToPtr(o));
		}

		// Token: 0x06001FAA RID: 8106 RVA: 0x00066C54 File Offset: 0x00064E54
		public static uint GetMonoHeapSize()
		{
			return (uint)Profiler.GetMonoHeapSizeLong();
		}

		// Token: 0x06001FAB RID: 8107 RVA: 0x000123CB File Offset: 0x000105CB
		public static long GetMonoHeapSizeLong()
		{
			return Profiler.GetMonoHeapSizeLongDelegateField();
		}

		// Token: 0x06001FAC RID: 8108 RVA: 0x00066C6C File Offset: 0x00064E6C
		public static uint GetMonoUsedSize()
		{
			return (uint)Profiler.GetMonoUsedSizeLong();
		}

		// Token: 0x06001FAD RID: 8109 RVA: 0x000123D7 File Offset: 0x000105D7
		public static long GetMonoUsedSizeLong()
		{
			return Profiler.GetMonoUsedSizeLongDelegateField();
		}

		// Token: 0x06001FAE RID: 8110 RVA: 0x000123E3 File Offset: 0x000105E3
		public static bool SetTempAllocatorRequestedSize(uint size)
		{
			return Profiler.SetTempAllocatorRequestedSizeDelegateField(size);
		}

		// Token: 0x06001FAF RID: 8111 RVA: 0x000123F0 File Offset: 0x000105F0
		public static uint GetTempAllocatorSize()
		{
			return Profiler.GetTempAllocatorSizeDelegateField();
		}

		// Token: 0x06001FB0 RID: 8112 RVA: 0x00066C84 File Offset: 0x00064E84
		public static uint GetTotalAllocatedMemory()
		{
			return (uint)Profiler.GetTotalAllocatedMemoryLong();
		}

		// Token: 0x06001FB1 RID: 8113 RVA: 0x000123FC File Offset: 0x000105FC
		public static long GetTotalAllocatedMemoryLong()
		{
			return Profiler.GetTotalAllocatedMemoryLongDelegateField();
		}

		// Token: 0x06001FB2 RID: 8114 RVA: 0x00066C9C File Offset: 0x00064E9C
		public static uint GetTotalUnusedReservedMemory()
		{
			return (uint)Profiler.GetTotalUnusedReservedMemoryLong();
		}

		// Token: 0x06001FB3 RID: 8115 RVA: 0x00012408 File Offset: 0x00010608
		public static long GetTotalUnusedReservedMemoryLong()
		{
			return Profiler.GetTotalUnusedReservedMemoryLongDelegateField();
		}

		// Token: 0x06001FB4 RID: 8116 RVA: 0x00066CB4 File Offset: 0x00064EB4
		public static uint GetTotalReservedMemory()
		{
			return (uint)Profiler.GetTotalReservedMemoryLong();
		}

		// Token: 0x06001FB5 RID: 8117 RVA: 0x00012414 File Offset: 0x00010614
		public static long GetTotalReservedMemoryLong()
		{
			return Profiler.GetTotalReservedMemoryLongDelegateField();
		}

		// Token: 0x06001FB6 RID: 8118 RVA: 0x00066CCC File Offset: 0x00064ECC
		public static long GetTotalFragmentationInfo(Unity.Collections.NativeArray<int> stats)
		{
			return Profiler.InternalGetTotalFragmentationInfo((IntPtr)Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.GetUnsafePtr<int>(stats), stats.Length);
		}

		// Token: 0x06001FB7 RID: 8119 RVA: 0x00012420 File Offset: 0x00010620
		public static long InternalGetTotalFragmentationInfo(IntPtr pStats, int count)
		{
			return Profiler.InternalGetTotalFragmentationInfoDelegateField(pStats, count);
		}

		// Token: 0x06001FB8 RID: 8120 RVA: 0x0001242E File Offset: 0x0001062E
		public static long GetAllocatedMemoryForGraphicsDriver()
		{
			return Profiler.GetAllocatedMemoryForGraphicsDriverDelegateField();
		}

		// Token: 0x06001FB9 RID: 8121 RVA: 0x00066CF8 File Offset: 0x00064EF8
		public static void EmitFrameMetaData(Guid id, int tag, Array data)
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			Type elementType = data.GetType().GetElementType();
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsBlittable(elementType);
			if (flag2)
			{
				throw new ArgumentException(String.Format("{0} type used in Profiler.ReportFrameStats must be blittable", elementType));
			}
			Profiler.Internal_EmitFrameMetaData_Array(id.ToByteArray(), tag, data, data.Length, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf(elementType));
		}

		// Token: 0x06001FBA RID: 8122 RVA: 0x00066D60 File Offset: 0x00064F60
		public static void EmitFrameMetaData<T>(Guid id, int tag, List<T> data) where T : struct
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			Type typeFromHandle = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>());
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsBlittable(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()));
			if (flag2)
			{
				throw new ArgumentException(String.Format("{0} type used in Profiler.ReportFrameStats must be blittable", typeFromHandle));
			}
			Profiler.Internal_EmitFrameMetaData_Array(id.ToByteArray(), tag, NoAllocHelpers.ExtractArrayFromList(data), data.Count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf(typeFromHandle));
		}

		// Token: 0x06001FBB RID: 8123 RVA: 0x0001243A File Offset: 0x0001063A
		public unsafe static void EmitFrameMetaData<T>(Guid id, int tag, Unity.Collections.NativeArray<T> data) where T : struct
		{
			Profiler.Internal_EmitFrameMetaData_Native((void*)(&id), 16, tag, (IntPtr)data.GetUnsafeReadOnlyPtr<T>(), data.Length, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>());
		}

		// Token: 0x06001FBC RID: 8124 RVA: 0x00012460 File Offset: 0x00010660
		public static void Internal_EmitFrameMetaData_Array(Il2CppStructArray<byte> id, int tag, Array data, int count, int elementSize)
		{
			Profiler.Internal_EmitFrameMetaData_ArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtr(id), tag, IL2CPP.Il2CppObjectBaseToPtr(data), count, elementSize);
		}

		// Token: 0x06001FBD RID: 8125 RVA: 0x0001247C File Offset: 0x0001067C
		public unsafe static void Internal_EmitFrameMetaData_Native(void* id, int idLen, int tag, IntPtr data, int count, int elementSize)
		{
			Profiler.Internal_EmitFrameMetaData_NativeDelegateField(id, idLen, tag, data, count, elementSize);
		}

		// Token: 0x0400190C RID: 6412
		public const uint invalidProfilerArea = 4294967295U;

		// Token: 0x0400190D RID: 6413
		private static readonly Profiler.get_supportedDelegate get_supportedDelegateField = IL2CPP.ResolveICall<Profiler.get_supportedDelegate>("UnityEngine.Profiling.Profiler::get_supported");

		// Token: 0x0400190E RID: 6414
		private static readonly Profiler.get_logFileDelegate get_logFileDelegateField = IL2CPP.ResolveICall<Profiler.get_logFileDelegate>("UnityEngine.Profiling.Profiler::get_logFile");

		// Token: 0x0400190F RID: 6415
		private static readonly Profiler.set_logFileDelegate set_logFileDelegateField = IL2CPP.ResolveICall<Profiler.set_logFileDelegate>("UnityEngine.Profiling.Profiler::set_logFile");

		// Token: 0x04001910 RID: 6416
		private static readonly Profiler.get_enableBinaryLogDelegate get_enableBinaryLogDelegateField = IL2CPP.ResolveICall<Profiler.get_enableBinaryLogDelegate>("UnityEngine.Profiling.Profiler::get_enableBinaryLog");

		// Token: 0x04001911 RID: 6417
		private static readonly Profiler.set_enableBinaryLogDelegate set_enableBinaryLogDelegateField = IL2CPP.ResolveICall<Profiler.set_enableBinaryLogDelegate>("UnityEngine.Profiling.Profiler::set_enableBinaryLog");

		// Token: 0x04001912 RID: 6418
		private static readonly Profiler.get_maxUsedMemoryDelegate get_maxUsedMemoryDelegateField = IL2CPP.ResolveICall<Profiler.get_maxUsedMemoryDelegate>("UnityEngine.Profiling.Profiler::get_maxUsedMemory");

		// Token: 0x04001913 RID: 6419
		private static readonly Profiler.set_maxUsedMemoryDelegate set_maxUsedMemoryDelegateField = IL2CPP.ResolveICall<Profiler.set_maxUsedMemoryDelegate>("UnityEngine.Profiling.Profiler::set_maxUsedMemory");

		// Token: 0x04001914 RID: 6420
		private static readonly Profiler.get_enabledDelegate get_enabledDelegateField = IL2CPP.ResolveICall<Profiler.get_enabledDelegate>("UnityEngine.Profiling.Profiler::get_enabled");

		// Token: 0x04001915 RID: 6421
		private static readonly Profiler.set_enabledDelegate set_enabledDelegateField = IL2CPP.ResolveICall<Profiler.set_enabledDelegate>("UnityEngine.Profiling.Profiler::set_enabled");

		// Token: 0x04001916 RID: 6422
		private static readonly Profiler.get_enableAllocationCallstacksDelegate get_enableAllocationCallstacksDelegateField = IL2CPP.ResolveICall<Profiler.get_enableAllocationCallstacksDelegate>("UnityEngine.Profiling.Profiler::get_enableAllocationCallstacks");

		// Token: 0x04001917 RID: 6423
		private static readonly Profiler.set_enableAllocationCallstacksDelegate set_enableAllocationCallstacksDelegateField = IL2CPP.ResolveICall<Profiler.set_enableAllocationCallstacksDelegate>("UnityEngine.Profiling.Profiler::set_enableAllocationCallstacks");

		// Token: 0x04001918 RID: 6424
		private static readonly Profiler.SetAreaEnabledDelegate SetAreaEnabledDelegateField = IL2CPP.ResolveICall<Profiler.SetAreaEnabledDelegate>("UnityEngine.Profiling.Profiler::SetAreaEnabled");

		// Token: 0x04001919 RID: 6425
		private static readonly Profiler.GetAreaEnabledDelegate GetAreaEnabledDelegateField = IL2CPP.ResolveICall<Profiler.GetAreaEnabledDelegate>("UnityEngine.Profiling.Profiler::GetAreaEnabled");

		// Token: 0x0400191A RID: 6426
		private static readonly Profiler.AddFramesFromFile_InternalDelegate AddFramesFromFile_InternalDelegateField = IL2CPP.ResolveICall<Profiler.AddFramesFromFile_InternalDelegate>("UnityEngine.Profiling.Profiler::AddFramesFromFile_Internal");

		// Token: 0x0400191B RID: 6427
		private static readonly Profiler.BeginThreadProfilingInternalDelegate BeginThreadProfilingInternalDelegateField = IL2CPP.ResolveICall<Profiler.BeginThreadProfilingInternalDelegate>("UnityEngine.Profiling.Profiler::BeginThreadProfilingInternal");

		// Token: 0x0400191C RID: 6428
		private static readonly Profiler.BeginSampleImplDelegate BeginSampleImplDelegateField = IL2CPP.ResolveICall<Profiler.BeginSampleImplDelegate>("UnityEngine.Profiling.Profiler::BeginSampleImpl");

		// Token: 0x0400191D RID: 6429
		private static readonly Profiler.EndSampleDelegate EndSampleDelegateField = IL2CPP.ResolveICall<Profiler.EndSampleDelegate>("UnityEngine.Profiling.Profiler::EndSample");

		// Token: 0x0400191E RID: 6430
		private static readonly Profiler.get_usedHeapSizeLongDelegate get_usedHeapSizeLongDelegateField = IL2CPP.ResolveICall<Profiler.get_usedHeapSizeLongDelegate>("UnityEngine.Profiling.Profiler::get_usedHeapSizeLong");

		// Token: 0x0400191F RID: 6431
		private static readonly Profiler.GetRuntimeMemorySizeLongDelegate GetRuntimeMemorySizeLongDelegateField = IL2CPP.ResolveICall<Profiler.GetRuntimeMemorySizeLongDelegate>("UnityEngine.Profiling.Profiler::GetRuntimeMemorySizeLong");

		// Token: 0x04001920 RID: 6432
		private static readonly Profiler.GetMonoHeapSizeLongDelegate GetMonoHeapSizeLongDelegateField = IL2CPP.ResolveICall<Profiler.GetMonoHeapSizeLongDelegate>("UnityEngine.Profiling.Profiler::GetMonoHeapSizeLong");

		// Token: 0x04001921 RID: 6433
		private static readonly Profiler.GetMonoUsedSizeLongDelegate GetMonoUsedSizeLongDelegateField = IL2CPP.ResolveICall<Profiler.GetMonoUsedSizeLongDelegate>("UnityEngine.Profiling.Profiler::GetMonoUsedSizeLong");

		// Token: 0x04001922 RID: 6434
		private static readonly Profiler.SetTempAllocatorRequestedSizeDelegate SetTempAllocatorRequestedSizeDelegateField = IL2CPP.ResolveICall<Profiler.SetTempAllocatorRequestedSizeDelegate>("UnityEngine.Profiling.Profiler::SetTempAllocatorRequestedSize");

		// Token: 0x04001923 RID: 6435
		private static readonly Profiler.GetTempAllocatorSizeDelegate GetTempAllocatorSizeDelegateField = IL2CPP.ResolveICall<Profiler.GetTempAllocatorSizeDelegate>("UnityEngine.Profiling.Profiler::GetTempAllocatorSize");

		// Token: 0x04001924 RID: 6436
		private static readonly Profiler.GetTotalAllocatedMemoryLongDelegate GetTotalAllocatedMemoryLongDelegateField = IL2CPP.ResolveICall<Profiler.GetTotalAllocatedMemoryLongDelegate>("UnityEngine.Profiling.Profiler::GetTotalAllocatedMemoryLong");

		// Token: 0x04001925 RID: 6437
		private static readonly Profiler.GetTotalUnusedReservedMemoryLongDelegate GetTotalUnusedReservedMemoryLongDelegateField = IL2CPP.ResolveICall<Profiler.GetTotalUnusedReservedMemoryLongDelegate>("UnityEngine.Profiling.Profiler::GetTotalUnusedReservedMemoryLong");

		// Token: 0x04001926 RID: 6438
		private static readonly Profiler.GetTotalReservedMemoryLongDelegate GetTotalReservedMemoryLongDelegateField = IL2CPP.ResolveICall<Profiler.GetTotalReservedMemoryLongDelegate>("UnityEngine.Profiling.Profiler::GetTotalReservedMemoryLong");

		// Token: 0x04001927 RID: 6439
		private static readonly Profiler.InternalGetTotalFragmentationInfoDelegate InternalGetTotalFragmentationInfoDelegateField = IL2CPP.ResolveICall<Profiler.InternalGetTotalFragmentationInfoDelegate>("UnityEngine.Profiling.Profiler::InternalGetTotalFragmentationInfo");

		// Token: 0x04001928 RID: 6440
		private static readonly Profiler.GetAllocatedMemoryForGraphicsDriverDelegate GetAllocatedMemoryForGraphicsDriverDelegateField = IL2CPP.ResolveICall<Profiler.GetAllocatedMemoryForGraphicsDriverDelegate>("UnityEngine.Profiling.Profiler::GetAllocatedMemoryForGraphicsDriver");

		// Token: 0x04001929 RID: 6441
		private static readonly Profiler.Internal_EmitFrameMetaData_ArrayDelegate Internal_EmitFrameMetaData_ArrayDelegateField = IL2CPP.ResolveICall<Profiler.Internal_EmitFrameMetaData_ArrayDelegate>("UnityEngine.Profiling.Profiler::Internal_EmitFrameMetaData_Array");

		// Token: 0x0400192A RID: 6442
		private static readonly Profiler.Internal_EmitFrameMetaData_NativeDelegate Internal_EmitFrameMetaData_NativeDelegateField = IL2CPP.ResolveICall<Profiler.Internal_EmitFrameMetaData_NativeDelegate>("UnityEngine.Profiling.Profiler::Internal_EmitFrameMetaData_Native");

		// Token: 0x02000C39 RID: 3129
		// (Invoke) Token: 0x0600365A RID: 13914
		private delegate bool get_supportedDelegate();

		// Token: 0x02000C3A RID: 3130
		// (Invoke) Token: 0x0600365C RID: 13916
		private delegate IntPtr get_logFileDelegate();

		// Token: 0x02000C3B RID: 3131
		// (Invoke) Token: 0x0600365E RID: 13918
		private delegate void set_logFileDelegate(IntPtr value);

		// Token: 0x02000C3C RID: 3132
		// (Invoke) Token: 0x06003660 RID: 13920
		private delegate bool get_enableBinaryLogDelegate();

		// Token: 0x02000C3D RID: 3133
		// (Invoke) Token: 0x06003662 RID: 13922
		private delegate void set_enableBinaryLogDelegate(bool value);

		// Token: 0x02000C3E RID: 3134
		// (Invoke) Token: 0x06003664 RID: 13924
		private delegate int get_maxUsedMemoryDelegate();

		// Token: 0x02000C3F RID: 3135
		// (Invoke) Token: 0x06003666 RID: 13926
		private delegate void set_maxUsedMemoryDelegate(int value);

		// Token: 0x02000C40 RID: 3136
		// (Invoke) Token: 0x06003668 RID: 13928
		private delegate bool get_enabledDelegate();

		// Token: 0x02000C41 RID: 3137
		// (Invoke) Token: 0x0600366A RID: 13930
		private delegate void set_enabledDelegate(bool value);

		// Token: 0x02000C42 RID: 3138
		// (Invoke) Token: 0x0600366C RID: 13932
		private delegate bool get_enableAllocationCallstacksDelegate();

		// Token: 0x02000C43 RID: 3139
		// (Invoke) Token: 0x0600366E RID: 13934
		private delegate void set_enableAllocationCallstacksDelegate(bool value);

		// Token: 0x02000C44 RID: 3140
		// (Invoke) Token: 0x06003670 RID: 13936
		private delegate void SetAreaEnabledDelegate(ProfilerArea area, bool enabled);

		// Token: 0x02000C45 RID: 3141
		// (Invoke) Token: 0x06003672 RID: 13938
		private delegate bool GetAreaEnabledDelegate(ProfilerArea area);

		// Token: 0x02000C46 RID: 3142
		// (Invoke) Token: 0x06003674 RID: 13940
		private delegate void AddFramesFromFile_InternalDelegate(IntPtr file, bool keepExistingFrames);

		// Token: 0x02000C47 RID: 3143
		// (Invoke) Token: 0x06003676 RID: 13942
		private delegate void BeginThreadProfilingInternalDelegate(IntPtr threadGroupName, IntPtr threadName);

		// Token: 0x02000C48 RID: 3144
		// (Invoke) Token: 0x06003678 RID: 13944
		private delegate void BeginSampleImplDelegate(IntPtr name, IntPtr targetObject);

		// Token: 0x02000C49 RID: 3145
		// (Invoke) Token: 0x0600367A RID: 13946
		private delegate void EndSampleDelegate();

		// Token: 0x02000C4A RID: 3146
		// (Invoke) Token: 0x0600367C RID: 13948
		private delegate long get_usedHeapSizeLongDelegate();

		// Token: 0x02000C4B RID: 3147
		// (Invoke) Token: 0x0600367E RID: 13950
		private delegate long GetRuntimeMemorySizeLongDelegate(IntPtr o);

		// Token: 0x02000C4C RID: 3148
		// (Invoke) Token: 0x06003680 RID: 13952
		private delegate long GetMonoHeapSizeLongDelegate();

		// Token: 0x02000C4D RID: 3149
		// (Invoke) Token: 0x06003682 RID: 13954
		private delegate long GetMonoUsedSizeLongDelegate();

		// Token: 0x02000C4E RID: 3150
		// (Invoke) Token: 0x06003684 RID: 13956
		private delegate bool SetTempAllocatorRequestedSizeDelegate(uint size);

		// Token: 0x02000C4F RID: 3151
		// (Invoke) Token: 0x06003686 RID: 13958
		private delegate uint GetTempAllocatorSizeDelegate();

		// Token: 0x02000C50 RID: 3152
		// (Invoke) Token: 0x06003688 RID: 13960
		private delegate long GetTotalAllocatedMemoryLongDelegate();

		// Token: 0x02000C51 RID: 3153
		// (Invoke) Token: 0x0600368A RID: 13962
		private delegate long GetTotalUnusedReservedMemoryLongDelegate();

		// Token: 0x02000C52 RID: 3154
		// (Invoke) Token: 0x0600368C RID: 13964
		private delegate long GetTotalReservedMemoryLongDelegate();

		// Token: 0x02000C53 RID: 3155
		// (Invoke) Token: 0x0600368E RID: 13966
		private delegate long InternalGetTotalFragmentationInfoDelegate(IntPtr pStats, int count);

		// Token: 0x02000C54 RID: 3156
		// (Invoke) Token: 0x06003690 RID: 13968
		private delegate long GetAllocatedMemoryForGraphicsDriverDelegate();

		// Token: 0x02000C55 RID: 3157
		// (Invoke) Token: 0x06003692 RID: 13970
		private delegate void Internal_EmitFrameMetaData_ArrayDelegate(IntPtr id, int tag, IntPtr data, int count, int elementSize);

		// Token: 0x02000C56 RID: 3158
		// (Invoke) Token: 0x06003694 RID: 13972
		private delegate void Internal_EmitFrameMetaData_NativeDelegate(IntPtr id, int idLen, int tag, IntPtr data, int count, int elementSize);
	}
}
